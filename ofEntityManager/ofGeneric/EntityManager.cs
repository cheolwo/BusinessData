using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;

namespace BusinessLogic.ofEntityManager.ofGeneric
{
    public interface IDataManager
    {
        Type GetManagerType();
        void SetMangaerType(Type t);
    }
    // 값이 입력되면 형변환이 이루어지도록 하는 게 맞지.
    public interface IEntityManager<TEntity> where TEntity : Entity
    {
        Task<TEntity> CreateWithBlobContainer(TEntity entity, string connectionString);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> CreateAsync(TEntity entity, List<IFormFile> formFiles, string connectionString);
        Task<TEntity> CreateAsync(TEntity entity, List<IBrowserFile> Files, string connectionString);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task UpdateAttachAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity, List<IBrowserFile> Files);
        Task<List<TEntity>> GetToListByUserAsync(IdentityUser user);
        Task<List<TEntity>> GetToListAsync();
        Task<TEntity> GetByCodeAsync(string Code);
        Task<TEntity> GetByIdAsync(string Id);
        Task<TEntity> GetByUserId(string UserId);
        Task DeleteByIdAsync(string Id);
        Dictionary<int, TEntity> ConvertToDic(List<TEntity> entities);
        Task ExcelToDb(string fileconnectionstring, Dictionary<PropertyInfo, int> target);
        Task<List<TEntity>> ExcelToEntities(string fileconnectionstring, Dictionary<PropertyInfo, int> target);
        object[, ] GetExcelDatas(string fileconnectionstring);
        Task EntitiesToDb(List<TEntity> entities);
        Task EntitiesToDbAttach(List<TEntity> entities);
    }
    
    // 데이터 적합성 검사의 경우는 ApplicationLayer 단에서 해결해야될 문제야.
    public class DataManagerAttribute : Attribute
    {
        private readonly Type type;
        public DataManagerAttribute(Type T)
        {
            type = T;
        }
        public Type GetManagerType()
        {
            return type;
        }
    }
    public abstract class DataManager : IDataManager
    {
        private Type T;
        public DataManager(Type T)
        {
            this.T = T;
        }
        public Type GetManagerType()
        {
            return T;
        }
        public void SetMangaerType(Type t)
        {
            this.T = t;
        }
        // public Type Rescope(Entity entity)
        // {
        //     string RelationCode = entity.GetRelationCode();

        // }
    }
    public class EntityManager<TEntity> : IEntityManager<TEntity> where TEntity : Entity, new()
    {
        public readonly IEntityDataRepository<TEntity> _EntityDataRepository;
        protected readonly IEntityIdFactory<TEntity> _EntityIdFactory;
        protected readonly IEntityFileFactory<TEntity> _EntityFileFactory;
        protected readonly IEntityBlobStorage<TEntity> _EntityBlobStorage;
        protected readonly DicConvertFactory<TEntity> _DicConvertFactory;

        public EntityManager(IEntityDataRepository<TEntity> EntityDataRepository,
                            IEntityIdFactory<TEntity> EntityIdFactory,
                            IEntityFileFactory<TEntity> entityFileFactory,
                            IEntityBlobStorage<TEntity> EntityBlobStorage,
                            DicConvertFactory<TEntity> DicConvertFactory
                            )
        {
            _EntityBlobStorage = EntityBlobStorage;
            _EntityIdFactory = EntityIdFactory;
            _EntityDataRepository = EntityDataRepository;
            _EntityFileFactory = entityFileFactory;
            _DicConvertFactory = DicConvertFactory;
        }

        //public virtual async Task<IEnumerable<EntityDTO>> GetToListAsync(EntityDTO entityDTO)
        //{
        //    List<EntityDTO> entityDTOs = new();
        //    var distributed = entityDTO.GetByQueryAttribute().DistributedByQueryCode();
        //    var keyProps = dictionary[QueryCode.Key];
        //    var StringProps = dictionary[QueryCode.QueryString];
        //    var IntProps = dictionary[QueryCode.QueryInt];
            
        //    if(keyProps.Count > 0)
        //    {
        //        var keyProp = distributed[QueryCode.Key].FirstOrDefault();
        //        var model = _entiyDataRepository.GetByIdAsync((string)keyProp.GetValue(dto));
        //        if(model == null) {throw new ArgumentException("Model Is Null");}
        //        var dto = model.ConvertToDTO();
        //        return dtos.Add(dto);
        //    }
            
            
        //    return entityDTOs;
        //}
        //public virtual async Task DeleteAsync(EntityDTO entityDTO)
        //{

        //}

        public virtual async Task<TEntity> CreateAsync(TEntity entity, List<IBrowserFile> files, string connectionString)
        {
            entity.Id = await _EntityIdFactory.CreateAsync(entity);
            entity.CreateTime = DateTime.Now;
            if (files.Count > 0)
            {
                TEntity BlobUploadEntity = await _EntityBlobStorage.UploadAsync(entity, files, connectionString);
                return await _EntityDataRepository.AddAsync(BlobUploadEntity);
            }
            return await _EntityDataRepository.AddAsync(entity);
        }
        public async Task<TEntity> CreateAsync(TEntity entity, List<IFormFile> formFiles, string connectionString)
        {
            entity.Id = await _EntityIdFactory.CreateAsync(entity);
            entity.CreateTime = DateTime.Now;
            if (formFiles.Count > 0)
            {
                TEntity BlobUploadEntity = await _EntityBlobStorage.UploadAsync(entity, formFiles, connectionString);
                return await _EntityDataRepository.AddAsync(BlobUploadEntity);
            }
            return await _EntityDataRepository.AddAsync(entity);
        }
        public virtual async Task<TEntity> CreateWithBlobContainer(TEntity entity, string connectionString)
        {
            entity.Id = await _EntityIdFactory.CreateAsync(entity);
            entity.CreateTime = DateTime.Now;
            _EntityBlobStorage.CreateBlobContainer(entity, connectionString);
            return await _EntityDataRepository.AddAsync(entity);
        }
        public async Task<TEntity> UpdateAsync(TEntity entity, List<IBrowserFile> files, string connectionString)
        {
            TEntity BlobUploadEntity = await _EntityBlobStorage.UploadAsync(entity, files, connectionString);
            return await _EntityDataRepository.UpdateAsync(BlobUploadEntity);
        }
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            return await _EntityDataRepository.UpdateAsync(entity);
        }
        public Dictionary<int, TEntity> ConvertToDic(List<TEntity> entities)
        {
            return _DicConvertFactory.ConvertToHashTable(entities);
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            entity.Id = await _EntityIdFactory.CreateAsync(entity);
            entity.CreateTime = DateTime.Now;
            return await _EntityDataRepository.AddAsync(entity);
        }

        public async Task DeleteByIdAsync(string Id)
        {
            TEntity entity = await _EntityDataRepository.GetByIdAsync(Id);
            await _EntityDataRepository.DeleteByIdAsync(Id);
        }

        public async Task<List<TEntity>> GetToListAsync()
        {
            return await _EntityDataRepository.GetToListAsync();
        }

        public Task<TEntity> CreateAsync(TEntity entity, List<IBrowserFile> Files)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity, List<IBrowserFile> Files)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> GetToListByUserAsync(IdentityUser user)
        {
            return await _EntityDataRepository.GetToListByUserAsync(user);
        }

        public async Task<TEntity> GetByCodeAsync(string Code)
        {
            return await _EntityDataRepository.GetByCodeAsync(Code);
        }

        public async Task<List<TEntity>> ExcelToEntities(string fileconnectionstring, Dictionary<PropertyInfo, int> target)
        {
            int count = await _EntityDataRepository.GetCountAsync();
            var datas = _EntityFileFactory.InitExcelData(fileconnectionstring);
            var entities = _EntityFileFactory.SetExcelEntities(datas, target);
            List<TEntity> SetIdEntities = _EntityIdFactory.SetEntityId(entities, count);
            return SetIdEntities;
        }

        public object[,] GetExcelDatas(string fileconnectionstring)
        {
            return _EntityFileFactory.InitExcelData(fileconnectionstring);
        }


        public async Task<TEntity> GetByIdAsync(string Id)
        {
            return await _EntityDataRepository.GetByIdAsync(Id);
        }


        public async Task UpdateAttachAsync(TEntity entity)
        {
            await _EntityDataRepository.UpdateAttachAsync(entity);
        }

        public Task<TEntity> GetByUserId(string UserId)
        {
            throw new NotImplementedException();
        }

        public Task ExcelToDb(string fileconnectionstring, Dictionary<PropertyInfo, int> target)
        {
            throw new NotImplementedException();
        }

        public Task EntitiesToDb(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public Task EntitiesToDbAttach(List<TEntity> entities)
        {
            throw new NotImplementedException();
        }
    }
}