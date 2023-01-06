using Azure.Storage.Blobs.Models;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BusinessData.ofDataContext
{
    public class DataContextAttribute : Attribute
    {
        private Type t;
        public DataContextAttribute(Type type)
        {
            t = type;
        }
        public Type T
        {
            get => t;
        }
    }
    // IServiceScopeFactory is always a Singleton but the IServiceProvider can vary based on the lifetime of the containing class.
    /*
        public class Singleton : ISingleton 
        {
            private readonly IServiceScopeFactory scopeFactory;

            public Singleton(IServiceScopeFactory scopeFactory)
            {
                this.scopeFactory = scopeFactory;
            }

            public void MyMethod() 
            {
                using(var scope = scopeFactory.CreateScope()) 
                {
                    var db = scope.ServiceProvider.GetRequiredService<DbContext>();

                    // when we exit the using block,
                    // the IServiceScope will dispose itself 
                    // and dispose all of the services that it resolved.
                }
            }
        }
    */
    /*
     Controller 에는 SeviceProvider 가 주입 되도록 한다.
     그래야 Model 개체에서 확장 메서드를 통해 DataContext에 접근할 수 있기 때문이다.
    */
    /*
        IMemoryCache(Singleton)
        IServiceScopeFactory, ---> DbContext, BackUpDbContext
        IServiceProvider ----> serviceProvider.GetRequiredService<DataContext>();
        // 이 위에 DataContext 가 업무단위별로 달라지는 면이 있으니까 Warehouse, GroupOrder
        등으로 나눠 논 것이지.
    */
    // 사용자 Db 의 Options 을 저장하는 경우 그 데이터와 Mapping 하는 논리가 필요하다.
    public class DataContextOptions
    {
        private bool _IsUseInMemory;
        private bool _IsDistributeCache;
        private bool _IsSnsAlarm;
        private bool _IsKakaoAlarm;
        private bool _IsEamliAlarm;
        public DataContextOptions(Func<DataContextOptions> options)
        {

        }
    }
    public class DataContext
    {
        public EntityManagerBuilder entityManagerBuilder = new();
        //protected readonly IMemoryCache _MemoryCache;
        //protected readonly IDistributedCache _DistributedCache;
        protected readonly IServiceScopeFactory _ServiceScopeFactory;
        public DataContext(IServiceScopeFactory serviceScopeFactory)
        {
            _ServiceScopeFactory = serviceScopeFactory;
            OnEntityIdBuilder(entityManagerBuilder);
            OnEntityBlobStorageBuilder(entityManagerBuilder);
            OnEntityExcelBuilder(entityManagerBuilder);
            OnEntityPDFBuilder(entityManagerBuilder);
            OnEntityRepositoryBuilder(entityManagerBuilder);
        }
        protected virtual void OnEntityIdBuilder(EntityManagerBuilder entityManagerBuilder) { }
        protected virtual void OnEntityBlobStorageBuilder(EntityManagerBuilder entityManagerBuilder) { }
        protected virtual void OnEntityRepositoryBuilder(EntityManagerBuilder entityManagerBuilder) { }
        protected virtual void OnEntityExcelBuilder(EntityManagerBuilder entityManagerBuilder) { }
        protected virtual void OnEntityPDFBuilder(EntityManagerBuilder entityManagerBuilder) { }
        public async Task<T> PostAsync<T>(T t) where T : Entity
        {
            IEntityDataRepository repository = entityManagerBuilder.GetEntityDataRepository(typeof(T).Name);
            IEntityIdFactory IdFactory = entityManagerBuilder.GetEntityIdFactory(typeof(T).Name);
            using (var serviceScope = _ServiceScopeFactory.CreateScope())
            {
                var DbContextType = t.GetDbContextType(typeof(T));
                DbContext dbContext = (DbContext)serviceScope.ServiceProvider.GetRequiredService(DbContextType);
                if(t.Id == null)
                {
                    await IdFactory.ConfigureIdAsync(t, dbContext, repository);
                }
                t = (T)await repository.InsertOrUpdate(t, dbContext);
            }
            return t;
        }
        public async Task<T> PutAsync<T>(T t) where T : Entity
        {
            IEntityDataRepository<T> repository = (IEntityDataRepository<T>)entityManagerBuilder.GetEntityDataRepository(typeof(T).Name);
            using (var serviceScope = _ServiceScopeFactory.CreateScope())
            {
                var DbContextType = t.GetDbContextType(typeof(T));
                DbContext dbContext = (DbContext)serviceScope.ServiceProvider.GetRequiredService(DbContextType);
                repository.SetDbContext(dbContext);
                await repository.UpdateAttachAsync(t);
                t = await repository.GetByIdAsync(t.Id);
            }
            return t;
        }
        public async Task<T> GetByIdAsync<T>(string id) where T : Entity, new()
        {
            IEntityDataRepository<T> repository = (IEntityDataRepository<T>)entityManagerBuilder.GetEntityDataRepository(typeof(T).Name);
            using (var serviceScope = _ServiceScopeFactory.CreateScope())
            {
                T t = new();
                var DbContextType = t.GetDbContextType(typeof(T));
                DbContext dbContext = (DbContext)serviceScope.ServiceProvider.GetRequiredService(DbContextType);
                repository.SetDbContext(dbContext);

                return await repository.GetByIdAsync(id);
            }
        }
        public async Task<T> GetByNameAsync<T>(string name) where T : Entity, new()
        {
            IEntityDataRepository<T> repository = (IEntityDataRepository<T>)entityManagerBuilder.GetEntityDataRepository(typeof(T).Name);
            using (var serviceScope = _ServiceScopeFactory.CreateScope())
            {
                T t = new();
                var DbContextType = t.GetDbContextType(typeof(T));
                DbContext dbContext = (DbContext)serviceScope.ServiceProvider.GetRequiredService(DbContextType);
                repository.SetDbContext(dbContext);

                return await repository.GetByNameAsync(name);
            }
        }

        public async Task DeleteByIdAsync<T>(string id) where T : Entity, new()
        {
            IEntityDataRepository<T> repository = (IEntityDataRepository<T>)entityManagerBuilder.GetEntityDataRepository(typeof(T).Name);
            using (var serviceScope = _ServiceScopeFactory.CreateScope())
            {
                T t = new();
                var DbContextType = t.GetDbContextType(typeof(T));
                DbContext dbContext = (DbContext)serviceScope.ServiceProvider.GetRequiredService(DbContextType);
                repository.SetDbContext(dbContext);
           
                await repository.DeleteByIdAsync(id);
            }
        }
        public async Task<List<T>> GetsAsync<T>() where T : Entity, new()
        {
            IEntityDataRepository<T> repository = (IEntityDataRepository<T>)entityManagerBuilder.GetEntityDataRepository(typeof(T).Name);
            using (var serviceScope = _ServiceScopeFactory.CreateScope())
            {
                T t = new();
                var DbContextType = t.GetDbContextType(typeof(T));
                DbContext dbContext = (DbContext)serviceScope.ServiceProvider.GetRequiredService(DbContextType);
                repository.SetDbContext(dbContext);
                return await repository.GetToListAsync();
            }
        }
        public async Task<List<string>> GetBlobItemsAsync<T>(T t, string connectionString) where T : Entity, new()
        {
            IEntityBlobStorage<T> blobStorage = (IEntityBlobStorage<T>)entityManagerBuilder.GetEntityBlobStorage(typeof(T).Name);
            var updatvalue = await blobStorage.GetToListBlobUrlByContainerName(t.Container, connectionString);
            return updatvalue;
        }
        public async Task BlobUploadAsync<T>(T t, string connectionString) where T : Entity, new()
        {
            IEntityBlobStorage<T> blobStorage = (IEntityBlobStorage<T>)entityManagerBuilder.GetEntityBlobStorage(typeof(T).Name);
            var updatvalue = await blobStorage.UploadImageAsync(t, connectionString);
            await PutAsync(updatvalue);
        }
        public async Task BlobUploadAsync<T>(T t, List<ImageofInfo> imageofInfos, string connectionString) where T : Entity, new()
        {
            IEntityBlobStorage<T> blobStorage = (IEntityBlobStorage<T>)entityManagerBuilder.GetEntityBlobStorage(typeof(T).Name);
            var updatevalue = await blobStorage.UploadImageAsync(t, imageofInfos, connectionString);
            await PutAsync(updatevalue);
        }
        public async Task DeleteBlobContainer<T>(T t, string connectionString) where T : Entity, new()
        {
            IEntityBlobStorage<T> blobStorage = (IEntityBlobStorage<T>)entityManagerBuilder.GetEntityBlobStorage(typeof(T).Name);
            await blobStorage.DeleteBlobAsync(t, connectionString);
        }
        public async Task ChangeContainerAccessLevelToPublic<T>(T t, string connetionString) where T : Entity, new()
        {
            IEntityBlobStorage<T> blobStorage = (IEntityBlobStorage<T>)entityManagerBuilder.GetEntityBlobStorage(typeof(T).Name);
            await blobStorage.ChangeAccessLevelToPublic(t, connetionString);
        }
        public async Task<FileStream> ConvertToExcelFileStream<T>(T t, string FileName) where T : Entity, new()
        {
            IEntityExcelFileFactory<T> entityExcelFileFactory = (IEntityExcelFileFactory<T>)entityManagerBuilder.GetEntityExcelFileFactory(typeof(T).Name);
            var filestream = await entityExcelFileFactory.ConvertToFileStream(t, FileName);
            return filestream;
        }
    }
    public class EntityManagerBuilder
    {
        // 여기서 string 값이 될 예로 nameof(Warehouse), nameof(WCommodity)... 등이 있다.
        private Dictionary<string, IEntityDataRepository> DicEntityDataRepository = new();
        private Dictionary<string, IEntityIdFactory> DicEntityIdFactory = new();
        private Dictionary<string, IEntityBlobStorage> DicEntityBlobStorage = new();
        private Dictionary<string, IEntityPDFFileFactory> DicEntityPDFFileFactory = new();
        private Dictionary<string, IEntityExcelFileFactory> DicEntityExcelFileFactory = new();
        public virtual void ApplyEntityDataRepository(string nameofEntityDataRepository, IEntityDataRepository entityDataRepository)
        {
            DicEntityDataRepository.Add(nameofEntityDataRepository, entityDataRepository);
        }
        public virtual void ApplyEntityIdFactory(string nameofEntityIdFactory, IEntityIdFactory entityIdFactory) 
        {
            DicEntityIdFactory.Add(nameofEntityIdFactory, entityIdFactory);
        }
        public virtual void ApplyEntityPDFFileFactory(string nameofEntityPDFFileFactory, IEntityPDFFileFactory EntityPDFFileFactory) 
        {
            DicEntityPDFFileFactory.Add(nameofEntityPDFFileFactory, EntityPDFFileFactory);
        }
        public virtual void ApplyEntityExcelFileFactory(string nameofEntityExcelFileFactory, IEntityExcelFileFactory entityExcelFileFactory)
        {
            DicEntityExcelFileFactory.Add(nameofEntityExcelFileFactory, entityExcelFileFactory);
        }
        public virtual void ApplyEntityBlobStorage(string nameofEntityBlobStorage, IEntityBlobStorage entityBlobStorage)
        {
            DicEntityBlobStorage.Add(nameofEntityBlobStorage, entityBlobStorage);
        }
        public IEntityDataRepository GetEntityDataRepository(string name)
        {
            return DicEntityDataRepository[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
        public IEntityIdFactory GetEntityIdFactory(string name)
        {
            return DicEntityIdFactory[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
        public IEntityBlobStorage GetEntityBlobStorage(string name)
        {
            return DicEntityBlobStorage[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
        public IEntityPDFFileFactory GetEntityPDFFileFactory(string name)
        {
            return DicEntityPDFFileFactory[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
        public IEntityExcelFileFactory GetEntityExcelFileFactory(string name)
        {
            return DicEntityExcelFileFactory[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
    }
    public interface IEntityIdConfiguration<TEntity> where TEntity : Entity
    {
        void Configure(EntityIdBuilder<TEntity> builder);
    }
    public interface IEntityFileConfiguration<TEntity> where TEntity : Entity
    {
        void Configure(EntityFileBuilder<TEntity> builder);
    }
    public interface IEntityBlobConfiguration<TEntity> where TEntity : Entity
    {
        void Configure(EntityBlobStorageBuilder<TEntity> builder);
    }
    public class EntityIdConfiguration<TEntity> : IEntityIdConfiguration<TEntity> where TEntity : Entity
    {
        public void Configure(EntityIdBuilder<TEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class EntityFileConfiguration<TEntity> : IEntityFileConfiguration<TEntity> where TEntity : Entity
    {
        public void Configure(EntityFileBuilder<TEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class EntityBlobStorageConfiguration<TEntity> : IEntityBlobConfiguration<TEntity> where TEntity : Entity
    {
        public void Configure(EntityBlobStorageBuilder<TEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class EntityIdBuilder<TEntity> where TEntity : Entity
    {
        
    }
    public class EntityFileBuilder<TEntity> where TEntity : Entity
    {

    }
    public class EntityBlobStorageBuilder<TEntity> where TEntity : Entity
    {

    }
}
