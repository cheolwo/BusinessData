using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofModelExtenstions
{
    public static class ModelDataContextExtenstions
    {
        public static async Task<Model> PostAsync<Model>(this Model model, DataContext dataContext) where Model : Entity
        {
            model = await dataContext.PostAsync(model);
            if (model != null)
            {
                return model;
            }
            throw new ArgumentNullException(nameof(model));
        }
        public static async Task<Model> PutAsync<Model>(this Model model, DataContext dataContext) where Model : Entity
        {
            model = await dataContext.PutAsync(model);
            if (model != null)
            {
                return model;
            }
            throw new ArgumentNullException(nameof(model));
        }
        public static async Task DeleteAsync<Model>(this Model model, DataContext dataContext) where Model : Entity, new()
        {
            if (model.Id != null)
            {
                await dataContext.DeleteByIdAsync<Model>(model.Id);
            }
            else
            {
                throw new ArgumentNullException(nameof(ModelDataContextExtenstions.DeleteAsync) + "Id Is Null");
            }
        }
        public static async Task UploadImageAsync<Model>(this Model model, DataContext dataContext, string connectionString) where Model : Entity, new()
        {
            if(model.ImageofInfos.Count > 0)
            {
                await dataContext.BlobUploadAsync(model, connectionString);
            }
        }
        public static async Task UploadDistintImageAsnyc<Model>(this Model model, List<ImageofInfo> imageofInfos, DataContext dataContext, string connectionString) where Model : Entity, new()
        {
            await dataContext.BlobUploadAsync<Model>(model, imageofInfos, connectionString);  
        }

        public static async Task<FileStream> ConvertToFileStream<Model>(this Model model, DataContext dataContext, string nameofFile) where Model : Entity, new()
        {
            FileStream file = await dataContext.ConvertToExcelFileStream(model, nameofFile);
            return file;
        }
        public static async Task<Model> GetByIdAsync<Model>(this Model model, DataContext dataContext) where Model : Entity, new()
        {
            if (model.Id != null)
            {
                return await dataContext.GetByIdAsync<Model>(model.Id);
            }
            throw new ArgumentNullException(nameof(ModelDataContextExtenstions.GetByIdAsync) + "Id Is Null");
        }
        public static async Task<Model> GetByNameAsync<Model>(this Model model, DataContext dataContext) where Model : Entity, new()
        {
            if (model.Name != null)
            {
                return await dataContext.GetByNameAsync<Model>(model.Name);
            }
            throw new ArgumentNullException(nameof(ModelDataContextExtenstions.GetByNameAsync) + "Name Is Null");
        }
        public static async Task<List<string>> GetBlobItemsAsync<Model>(this Model model, DataContext dataContext, string connectionString) where Model : Entity, new()
        {
            if(model.Container != null)
            {
                return await dataContext.GetBlobItemsAsync(model, connectionString);
            }
            throw new ArgumentNullException(nameof(model.Container) + "is null");
        }
    }
}
