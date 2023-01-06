using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessData.ofDataAccessLayer.ofCommon;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofDataAccessLayer.ofGeneric.ofRepository
{
    public interface IEntityDataRepository
    {
        Task<Entity> InsertOrUpdate(Entity entity, DbContext dbContext);
        Task<List<Entity>> GetToListAsync(DbContext dbContext);
        Task<Entity> AddAsync(Entity tentity, DbContext dbContext);
        Task<Entity> UpdateAsync(Entity tentity, DbContext dbContext);
        Task DeleteByIdAsync(string Id, DbContext dbContext);
        Task<Entity> GetByIdAsync(string Id, DbContext dbContext);
        Task<int> GetCountAsync(DbContext dbContext);
        Task<Entity> GetByContainerAsync(string containerName, DbContext dbContext);

        void SetDbContext(DbContext dbContext);
    }
    public abstract class EntityDataRepository : IEntityDataRepository
    {
        public abstract Task<Entity> AddAsync(Entity tentity, DbContext dbContext);
        public abstract Task DeleteByIdAsync(string Id, DbContext dbContext);
        public abstract Task<Entity> GetByIdAsync(string Id, DbContext dbContext);
        public abstract Task<List<Entity>> GetToListAsync(DbContext dbContext);
        public abstract Task<Entity> UpdateAsync(Entity tentity, DbContext dbContext);
        public abstract Task<Entity> GetByContainerAsync(string containerName, DbContext dbContext);
        public abstract Task<int> GetCountAsync(DbContext dbContext);
        public abstract void SetDbContext(DbContext dbContext);
        public abstract Task<Entity> InsertOrUpdate(Entity entity, DbContext dbContext);
    }

    public interface IEntityDataRepository<TEntity> : IEntityDataRepository where TEntity : Entity
    {
        // 기본
        Task<List<TEntity>> GetToListAsync();
        Task<TEntity> FirstOrDefaultAsync();
        Task<TEntity> AddAsync(TEntity tentity);
        Task<TEntity> UpdateAsync(TEntity tentity);
        Task DeleteByIdAsync(string Id);
        Task<TEntity> GetByIdAsync(string Id);
        Task AddEntitiesAsync(IList<TEntity> entities);
        Task AddEntitiesByAttachAsync(IList<TEntity> entities);
        Task UpdateAttachAsync(TEntity entity);

        // 특정 By
        Task<TEntity> GetByUserAsync(IdentityUser identityUser);
        Task<TEntity> GetByNameAsync(string Name);
        Task<TEntity> GetByContainerAsync(string containerName);
        Task<TEntity> GetByCodeAsync(string Code);
        Task<TEntity> GetByUserIdAsync(string UserId);
        Task<int> GetCountAsync();

        // GetToListBy
        Task<List<TEntity>> GetToListByUserIdAsync(string UserId);
        Task<List<TEntity>> GetToListByContainerAsync(string Container);
        Task<List<TEntity>> GetToListByNameAsync(string Name);
        Task<List<TEntity>> GetToListByCodeAsync(string Code);
        Task<List<TEntity>> GetToListByUserAsync(IdentityUser IdentityUser);
        Task<List<TEntity>> GetToListByBetweenDateTimeAsync(DateTime beforeDateTime, DateTime AfterDateTime);
        Task<List<TEntity>> GetToListByCreateTimeAsync(DateTime dateTime);
    }
    public class RepositoryOptions
    {
        private bool _UsedSingleton;
        private bool _UsingMemoryCache;
        private bool _UsingDistributedCache;
        public bool UsedSingleton
        {
            get => _UsedSingleton;
            set => _UsedSingleton = value;
        }
        public bool UsingMemoryCache
        {
            get => _UsingMemoryCache;
            set => _UsingMemoryCache = value;
        }
        public bool UsingDistributedCache
        {
            get => _UsingDistributedCache;
            set => _UsingDistributedCache = value;
        }

    }
    public class EntityDataRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : Entity, new()
    {
        protected DbContext _DbContext;
        public DbContext dbContext
        {
            get => _DbContext;
            set => _DbContext = value;
        }
        protected RepositoryOptions _RepositoryOptions = new();
        public EntityDataRepository(DbContext DbContext)
        {
            if (DbContext != null)
            {
                _DbContext = DbContext;
            }
            else { _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity))); }
        }
        public EntityDataRepository(Action<RepositoryOptions> options)
        {
            options.Invoke(_RepositoryOptions);
            if (_RepositoryOptions.UsedSingleton)
            {
                // Singleton 개체에 등록할 Repository 면 DbContext를 생성하면 안된다. 메서드 상에서 동적으로 실행해서 해제해야된다. DbContext 특성 상 Singleton을 허용하지 않기 때문이다.
            }
            else
            {
                _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity)));
            }
        }
        public EntityDataRepository()
        {
            //_DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity)));
        }
        public void SetDbContext(DbContext dbContext)
        {
            if (dbContext is not null)
            {
                _DbContext = dbContext;
            }
            else
            {
                throw new ArgumentNullException(nameof(DbContext) + "Is Null");
            }

        }
        public virtual async Task<TEntity> AddAsync(TEntity tentity)
        {
            await _DbContext.AddAsync(tentity);
            await _DbContext.SaveChangesAsync();
            TEntity entity = await _DbContext.FindAsync<TEntity>(tentity.Id);
            return entity;
        }
        public async Task<TEntity> GetByIdAsync(string Id)
        {
            var DbEntity = await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Id.Equals(Id));
            if (DbEntity != null)
            {
                return DbEntity;
            }
            throw new ArgumentNullException("Not Exist");
        }
        public async Task DeleteByIdAsync(string Id)
        {
            TEntity entity = await GetByIdAsync(Id);
            _DbContext.Remove(entity);
            await _DbContext.SaveChangesAsync();
        }
        protected readonly TEntity entity = new();


        public async Task<int> GetCountAsync()
        {
            return await _DbContext.Set<TEntity>().CountAsync();
        }
        public async Task<int> GetCountAsync(DbContext dbContext)
        {
            return await dbContext.Set<TEntity>().CountAsync();
        }

        public async Task<List<TEntity>> GetToListAsync()
        {
            return await _DbContext.Set<TEntity>().ToListAsync();
        }
        public List<TEntity> GetToList()
        {
            return _DbContext.Set<TEntity>().ToList();
        }

        public async Task<TEntity> UpdateAsync(TEntity tentity)
        {
            _DbContext.Update(tentity);
            await _DbContext.SaveChangesAsync();
            return await GetByIdAsync(tentity.Id);
        }
        public async Task UpdateAttachAsync(TEntity entity)
        {
            var attach = _DbContext.Attach(entity);
            attach.State = EntityState.Modified;
            await _DbContext.SaveChangesAsync();
        }
        public async Task<TEntity> GetByContainerAsync(string containerName)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Container.Equals(containerName));
        }

        public async Task<List<TEntity>> GetToListByBetweenDateTimeAsync(DateTime beforeDateTime, DateTime AfterDateTime)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.CreateTime >= beforeDateTime && e.CreateTime <= AfterDateTime).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByUserIdAsync(string UserId)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.UserId.Equals(UserId)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByUserAsync(IdentityUser IdentityUser)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.UserId.Equals(IdentityUser.Id)).ToListAsync();
        }

        public async Task<TEntity> GetByNameAsync(string Name)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Name.Equals(Name));
        }

        public async Task<TEntity> GetByUserAsync(IdentityUser identityUser)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.UserId.Equals(identityUser.Id));
        }

        public async Task<TEntity> FirstOrDefaultAsync()
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetByCodeAsync(string Code)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Code.Equals(Code));
        }

        public async Task AddEntitiesAsync(IList<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.CreateTime = DateTime.Now;
                _DbContext.Set<TEntity>().Add(entity);
                await _DbContext.SaveChangesAsync();
            }
        }

        public async Task AddEntitiesByAttachAsync(IList<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.CreateTime = DateTime.Now;
                var attach = _DbContext.Attach(entity);
                attach.State = EntityState.Modified;
                await _DbContext.SaveChangesAsync();
            }
        }


        public async Task<TEntity> GetByUserIdAsync(string UserId)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.UserId.Equals(UserId));
        }

        public async Task<List<TEntity>> GetToListBetweenStarnDateAndEndDateAsync(DateTime StartDate, DateTime EndDate)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.CreateTime >= StartDate && e.CreateTime <= EndDate).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListBetweenStarnDateAndEndDateAsync(string Container)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Container.Equals(Container)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByNameAsync(string Name)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Name.Equals(Name)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCodeAsync(string Code)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Code.Equals(Code)).ToListAsync();
        }

        public Task<List<TEntity>> GetToListByContainerAsync(string Container)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetToListByCreateTimeAsync(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<List<Entity>> GetToListAsync(DbContext dbContext)
        {
            var list = await dbContext.Set<TEntity>().ToListAsync();
            List<Entity> entities = new();
            foreach (var entity in list)
            {
                entities.Add(entity);
            }
            return entities;
        }

        public virtual async Task<Entity> AddAsync(Entity entity, DbContext dbContext)
        {
            await dbContext.AddAsync((TEntity)entity);
            await dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<Entity> UpdateAsync(Entity tentity, DbContext dbContext)
        {
            dbContext.Entry((TEntity)tentity).CurrentValues.SetValues((TEntity)tentity);
            await dbContext.SaveChangesAsync();
            return await GetByIdAsync(tentity.Id, dbContext);
        }

        public virtual async Task DeleteByIdAsync(string Id, DbContext dbContext)
        {
            var entity = await GetByIdAsync(Id, dbContext);
            _DbContext.Remove((TEntity)entity);
            await _DbContext.SaveChangesAsync();
        }

        public virtual async Task<Entity> GetByIdAsync(string Id, DbContext dbContext)
        {
            return await dbContext.FindAsync<TEntity>(Id);
        }

        public async Task<Entity> GetByContainerAsync(string containerName, DbContext dbContext)
        {
            return await dbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Container.Equals(containerName));
        }

        public async Task<Entity> InsertOrUpdate(Entity entity, DbContext dbContext)
        {
            var existing = await dbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Equals(entity));
            if (existing == null)
            {
                dbContext.Add((TEntity)entity);
            }
            else
            {
                dbContext.Entry(existing).CurrentValues.SetValues((TEntity)entity);
            }
            await dbContext.SaveChangesAsync();
            return await GetByIdAsync(entity.Id, dbContext);
        }
    }
}
