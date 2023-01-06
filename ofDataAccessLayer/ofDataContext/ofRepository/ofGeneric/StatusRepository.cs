using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofInterface;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofDataAccessLayer.ofGeneric.ofRepository
{
    public interface IStatusDataRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : Status
    {
        // Get By
        Task<TEntity> GetByCommodityIdAsync(string CommodityId);
        Task<TEntity> GetByCenterIdAsync(string CenterId);
        
        // GetToList By
        Task<List<TEntity>> GetToListByCommodityIdAsync(string CommodityId);
        Task<List<TEntity>> GetToListByCenterIdAsync(string CenterId);
        Task<List<TEntity>> GetToListByQuantityAsync(int MaxQuantity);
        Task<List<TEntity>> GetToListByQuntityAsync(int MinQuantity, int MaxQuantity);

        // Get By With
        Task<TEntity> GetByCommodityIdWithRelatedAsync(string CommodityId);
        Task<TEntity> GetByCenterIdWithRelatedAsync(string CenterId);
        // Get To List By With
        Task<List<TEntity>> GetToListByCommodityIdWithRelatedAsync(string CommodityId);
        Task<List<TEntity>> GetToListByCenterIdWithRelatedAsync(string CenterId);
        Task<List<TEntity>> GetToListByQuantityWithRelatedAsync(int MaxQuantity);
        Task<List<TEntity>> GetToListByQuntityWithRelatedAsync(int MinQuantity, int MaxQuantity);
    }
    public class StatusDataRepository<TEntity> : EntityDataRepository<TEntity>, IStatusDataRepository<TEntity> where TEntity : Status, new()
    {
        public StatusDataRepository(DbContext DbContext)
            :base(DbContext)
        {
            if (DbContext != null)
            {
                _DbContext = DbContext;
            }
            else { _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity))); }
        }
        public StatusDataRepository(Action<RepositoryOptions> options)
            : base(options)
        {
            
        }
        public async Task<List<TEntity>> GetToListByCountryCode(string CountryCode)
        {
            List<TEntity> TEntityes = await GetToListWithCenterAsync();
            TEntityes = TEntityes.Where(e => e.Center.CountryCode.Equals(CountryCode)).ToList();
            return TEntityes;
        }
        public async Task<List<TEntity>> GetToListWithCenterAsync()
        {
            return await _DbContext.Set<TEntity>().Include(TEntity => TEntity.Center).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithCommodityAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.Commodity).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCommodityIdAsync(string CommodityId)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.CommodityId.Equals(CommodityId)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCenterIdAsync(string CenterId)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.CenterId.Equals(CenterId)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByQuantityAsync(int MaxQuantity)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Quantity <= MaxQuantity).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByQuntityAsync(int MinQuantity, int MaxQuantity)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Quantity >= MinQuantity && e.Quantity <= MaxQuantity).ToListAsync();
        }

        public async Task<TEntity> GetByCommodityIdAsync(string CommodityId)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.CommodityId.Equals(CommodityId));
        }

        public async Task<TEntity> GetByCenterIdAsync(string CenterId)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.CenterId.Equals(CenterId));
        }
        public async Task<TEntity> GetByCommodityIdWithRelatedAsync(string CommodityId)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.CommodityId.Equals(CommodityId)).Include(e=>e.Center).Include(e=>e.Commodity).FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetByCenterIdWithRelatedAsync(string CenterId)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.CenterId.Equals(CenterId)).Include(e=>e.Center).Include(e=>e.Commodity).FirstOrDefaultAsync();
        }

        public async Task<List<TEntity>> GetToListByCommodityIdWithRelatedAsync(string CommodityId)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.CommodityId.Equals(CommodityId)).Include(e=>e.Center).Include(e=>e.Commodity).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCenterIdWithRelatedAsync(string CenterId)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.CenterId.Equals(CenterId)).Include(e=>e.Center).Include(e=>e.Commodity).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByQuantityWithRelatedAsync(int MaxQuantity)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Quantity <= MaxQuantity).Include(e=>e.Center).Include(e=>e.Commodity).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByQuntityWithRelatedAsync(int MinQuantity, int MaxQuantity)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Quantity >= MinQuantity && e.Quantity <= MaxQuantity).ToListAsync();
        }
    }
    public interface ISStatusDataRepository<TEntity> : IStatusDataRepository<TEntity> where TEntity : SStatus, new()
    {
        Task<List<TEntity>> GetToListWithMStatusesAsync();
    }
    public class SStatusDataRepository<TEntity> : StatusDataRepository<TEntity>, ISStatusDataRepository<TEntity> where TEntity : SStatus, new()
    {
        public SStatusDataRepository(DbContext DbContext) : base(DbContext)
        {
        }
        public async Task<List<TEntity>> GetToListWithMStatusesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.MStatuses).ToListAsync();
        }
    }
    public interface IMStatusDataRepository<TEntity> : IStatusDataRepository<TEntity> where TEntity : MStatus, new()
    {
        Task<List<TEntity>> GetToListWithEStatusesAsync();
        Task<List<TEntity>> GetToListWithSStatusAsync();
    }
    public class MStatusDataRepository<TEntity> : StatusDataRepository<TEntity>, IMStatusDataRepository<TEntity> where TEntity : MStatus, new()
    {
        public MStatusDataRepository(DbContext DbContext) : base(DbContext)
        {
        }

        public async Task<List<TEntity>> GetToListWithEStatusesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.EStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithSStatusAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.SStatus).ToListAsync();
        }
    }
    public interface IEStatusDataRepository<TEntity> : IStatusDataRepository<TEntity> where TEntity : EStatus, new()
    {
    }
    public class EStatusDataRepository<TEntity> : StatusDataRepository<TEntity>, IEStatusDataRepository<TEntity> where TEntity : EStatus, new()
    {
        public EStatusDataRepository(DbContext DbContext) : base(DbContext)
        {
        }
    }
}