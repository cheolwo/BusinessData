// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Flurl;
using System.Threading.Tasks;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage
{
    public class BlobOption
    {
        private string ConnectionString { get; set; }
        public BlobOption(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
    }
    public class BlobStorage
    {
        private BlobOption Option { get; set; }
        public BlobStorage(BlobOption option)
        {
            Option = option;
        }
    }
    public interface IEntityBlobStorage
    {
        
    }
    public interface IEntityBlobStorage<TEntity> : IEntityBlobStorage where TEntity : Entity
    {
        Task<TEntity> UploadAsync(TEntity entity, List<IFormFile> files, string connectionString);
        Task<TEntity> UploadAsync(TEntity entity, List<IBrowserFile> files, string connectionString);
        Task DownLoadAsync(TEntity entity, string downloadPath);
        Task<List<string>> GetToListBlobUrlByContainerName(string containerName, string connectionString);
        void CreateBlobContainer(TEntity entity, string connectionString);
        Task<TEntity> UploadImageAsync(TEntity entity, string connectionString);
        Task<TEntity> UploadImageAsync(TEntity entity, List<ImageofInfo> imageofInfos, string connectionString);
        Task DeleteBlobAsync(TEntity entity, string connectionString);
        Task ChangeAccessLevelToPublic(TEntity entity, string connectionString);
    }
    public class EntityBlobStorage<TEntity> : IEntityBlobStorage<TEntity> where TEntity : Entity
    {
        public EntityBlobStorage(IEntityContainerFactory<TEntity> entity)
        {

        }
        public EntityBlobStorage()
        {

        }
        public void CreateBlobContainer(TEntity entity, string connectionString)
        {
            bool IsCreateContainer = true;
            if (entity.Container == null)
            {
                BlobServiceClient blobServiceClient = new(connectionString);
                entity.Container = entity.Code.ToLower();
                var Containers = blobServiceClient.GetBlobContainers();
                foreach (var container in Containers)
                {
                    if (container.Name.Equals(entity.Container))
                    {
                        IsCreateContainer = false;
                    }
                }
                if (IsCreateContainer)
                {
                    blobServiceClient.CreateBlobContainer(entity.Container, PublicAccessType.BlobContainer);
                    
                }
            }
        }
        public async Task<TEntity> UploadAsync(TEntity entity, List<IBrowserFile> files, string connectionString)
        {
            BlobServiceClient blobServiceClient = new(connectionString);
            CreateBlobContainer(entity, connectionString);
            // 저장할 파일이 없다면 BlobStorage 이용할 필요 없으니 모듈 종료.
            if (files.Count == 0) {return entity;}

            // BlobStorage에서 컨테이너를 Load
            BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(entity.Container);
            // 해당 컨테이너에 파일을 저장.
            foreach (var file in files)
            {
                var Result = await blobContainerClient.UploadBlobAsync(file.Name, file.OpenReadStream());
                ImageofInfo imageofInfo = new();
                imageofInfo.fileName = file.Name;
                imageofInfo.Id = (int)Result.Value.BlobSequenceNumber;
                imageofInfo.Info = file.Size.ToString();
                imageofInfo.Purpose = "Image";
                entity.ImageofInfos.Add(imageofInfo);
            }
            return entity;
        }
        public async Task<TEntity> UploadImageAsync(TEntity entity, string connectionString)
        {
            BlobServiceClient blobServiceClient = new(connectionString);
            if(entity.Container == null)
            {
                CreateBlobContainer(entity, connectionString);
            }
            BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(entity.Container);
            var blobItems = blobContainerClient.GetBlobs();
            
            foreach (var image in entity.ImageofInfos)
            {
                var blobImageValue = blobItems.Where(e => e.Name == image.fileName).FirstOrDefault();
                var blob = blobContainerClient.GetBlobClient(image.fileName);
                var blobHttpHeader = new BlobHttpHeaders();
                blobHttpHeader.ContentType = "image/png";

                var FileStream = File.Open(image.Info, FileMode.Open);
                await blob.UploadAsync(FileStream, blobHttpHeader);
                Console.WriteLine(image.fileName);
                Console.Write(image.Info);
            }
            return entity;
        }
        /// <summary>
        /// 새로운 이미지인 ImageofInfos를 업로드하고 entity에 그에 대한 정보를 저장하는 단계
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="imageofInfos"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public async Task<TEntity> UploadImageAsync(TEntity entity, List<ImageofInfo> imageofInfos, string connectionString)
        {
            BlobServiceClient blobServiceClient = new(connectionString);
            if (entity.Container == null)
            {
                CreateBlobContainer(entity, connectionString);
            }
            BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(entity.Container);
            var blobItems = blobContainerClient.GetBlobs();
            foreach(var image in imageofInfos)
            {
                Console.WriteLine(image.fileName);
                var blobImageValue = blobItems.Where(e => e.Name == image.fileName).FirstOrDefault();
                var blob = blobContainerClient.GetBlobClient(image.fileName);
                var blobHttpHeader = new BlobHttpHeaders();
                blobHttpHeader.ContentType = "image/png";

                using (Image imagesharp = Image.Load(image.Info))
                {
                    if (imagesharp.Height != 1000 || imagesharp.Width != 1000)
                    {
                        imagesharp.Mutate(e => e.Resize(1000, 1000));
                        imagesharp.Save(image.Info);
                    }
                }
                using (var FileStream = File.Open(image.Info, FileMode.Open, FileAccess.Read))
                {
                    await blob.UploadAsync(FileStream, blobHttpHeader);
                    Console.WriteLine(image.fileName);
                    Console.Write(image.Info);
                }
            }
            return entity;
        }
        public async Task DeleteBlobAsync(TEntity entity, string connectionString)
        {
            BlobServiceClient blobServiceClient = new(connectionString);
            BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(entity.Container);
            await blobContainerClient.DeleteAsync();
        }
        public async Task<TEntity> UploadAsync(TEntity entity, List<IFormFile> files, string connectionString)
        {
            BlobServiceClient blobServiceClient = new(connectionString);
            CreateBlobContainer(entity, connectionString);
            // 저장할 파일이 없다면 BlobStorage 이용할 필요 없으니 모듈 종료.
            if (files.Count == 0) { return entity; }

            // BlobStorage에서 컨테이너를 Load
            BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(entity.Container);
           
            // 해당 컨테이너에 파일을 저장.
            foreach (var file in files)
            {
                var Result = await blobContainerClient.UploadBlobAsync(file.Name, file.OpenReadStream());
                ImageofInfo imageofInfo = new();
                imageofInfo.fileName = file.Name;
                imageofInfo.Id = (int)Result.Value.BlobSequenceNumber;
                imageofInfo.Info = file.Length.ToString();
                imageofInfo.Purpose = "Image";
                entity.ImageofInfos.Add(imageofInfo);
            }
            return entity;
        }
        public Task DownLoadAsync(TEntity entity, string downloadPath)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<string>> GetToListBlobUrlByContainerName(string containerName, string connectionString)
        {
            var containerClient = new BlobContainerClient(connectionString, containerName);
            var containerUri = containerClient.Uri.AbsoluteUri;
            List<string> results = new List<string>();
            await foreach (var blob in containerClient.GetBlobsAsync())
            {
                Console.WriteLine(blob.Name);
                results.Add(containerClient.Uri.AbsoluteUri + "/" + blob.Name);
            }
            return results;
        }

        public async Task ChangeAccessLevelToPublic(TEntity entity, string connectionString)
        {
            BlobServiceClient blobServiceClient = new(connectionString);
            BlobContainerClient blobContainerClient = blobServiceClient.GetBlobContainerClient(entity.Container);
            await blobContainerClient.SetAccessPolicyAsync(PublicAccessType.BlobContainer);
        }

    }

}
