using BusinessData.ofDataAccessLayer.ofCommon;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessData.ofDataAccessLayer.ofGeneric.ofRepository
{
    public interface ICommodityDataRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : Commodity
    {
        // GetBy
        Task<TEntity> GetByBarcodeAsync(string Barcode);
        Task<TEntity> GetByHsCodeAsnyc(string HsCode);
        Task<TEntity> GetByCenterIdAsnyc(string CenterId);

        // GetToListBy
        Task<List<TEntity>> GetToListByHsCodeAsync(string HsCode);
        Task<List<TEntity>> GetToListByCenterIdAsync(string CenterId);
        Task<List<TEntity>> GetToListByBarcodeAsync(string Barcode);

        // GetByWithRelated
        Task<TEntity> GetByBarcodeWithRelatedAsync(string Barcode);
        Task<TEntity> GetByHsCodeWithRelatedAsnyc(string HsCode);
        Task<TEntity> GetByCenterIdWithRelatedAsnyc(string CenterId);

        // GetToListByWithRelated
        Task<List<TEntity>> GetToListByHsCodeWithRelatedAsync(string HsCode);
        Task<List<TEntity>> GetToListByCenterIdWithRelatedAsync(string CenterId);
        Task<List<TEntity>> GetToListByBarcodeWithRelatedAsync(string Barcode);

        //With
        // Task<List<TEntity>> GetToListWithEStatusesAsync();
        // Task<List<TEntity>> GetToListWithMStatusesAsync();
        // Task<List<TEntity>> GetToListWithSStatusesAsync();

        // By With
        // Task<List<TEntity>> GetToListByCenterWithEStatuesAsync(Center Center);
        // Task<List<TEntity>> GetToListByCenterWithMStatuesAsync(Center Center);
        // Task<List<TEntity>> GetToListByCenterWithSStatuesAsync(Center Center);
        // Task<List<TEntity>> GetToListByCenterWithRelatedStatusesAsync(Center Center);

        // Task<List<TEntity>> GetToListByHsCodeWithEStatuesAsync(string HsCode);
        // Task<List<TEntity>> GetToListByHsCodeWithMStatuesAsync(string HsCode);
        // Task<List<TEntity>> GetToListByHsCodeWithSStatuesAsync(string HsCode);
        // Task<List<TEntity>> GetToListByHsCodeWithRelatedStatusesAsync(string HsCode);

        // Task<List<TEntity>> GetToListByBarcodeWithEStatuesAsync(string Barcode);
        // Task<List<TEntity>> GetToListByBarcodeWithMStatuesAsync(string Barcode);
        // Task<List<TEntity>> GetToListByBarcodeWithSStatuesAsync(string Barcode);
        // Task<List<TEntity>> GetToListByBarcodeWithRelatedStatusesAsync(string Barcode);

        // Task<List<TEntity>> GetToListByUserIdWithSStatusAsync(string UserId);
    }
    public class CommodityDataRepository<TEntity> : EntityDataRepository<TEntity>, ICommodityDataRepository<TEntity>
                                                     where TEntity : Commodity, new()
    {
        public CommodityDataRepository(DbContext DbContext)
            :base(DbContext)
        {
            if (DbContext != null)
            {
                _DbContext = DbContext;
            }
            else { _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity))); }
        }
        public CommodityDataRepository()
        {
            _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity)));
        }
        public CommodityDataRepository(Action<RepositoryOptions> options)
            :base(options)
        {

        }
        public async Task<TEntity> GetByBarcodeAsync(string Barcode)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.Barcode.Equals(Barcode));
        }

        public async Task<List<TEntity>> GetToListByBarcodeWithEStatuesAsync(string Barcode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Barcode.Equals(Barcode)).Include(entity => entity.EStatuses).
                                                                                                                        ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByBarcodeWithMStatuesAsync(string Barcode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Barcode.Equals(Barcode)).Include(entity => entity.MStatuses).
                                                                                                                        ToListAsync();
        }
        public async Task<List<TEntity>> GetToListByBarcodeWithSStatuesAsync(string Barcode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Barcode.Equals(Barcode)).Include(entity => entity.SStatuses).
                                                                                                                        ToListAsync();
        }
        public async Task<List<TEntity>> GetToListByBarcodeWithRelatedStatusesAsync(string Barcode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Barcode.Equals(Barcode)).Include(entity => entity.EStatuses).
                                                                                        Include(entity => entity.MStatuses).
                                                                                        Include(entity => entity.SStatuses).
                                                                                        ToListAsync();
        }
        public async Task<List<TEntity>> GetToListByCenterAsync(Center Center)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Center.Equals(Center)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCenterWithEStatuesAsync(Center Center)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Center.Equals(Center)).Include(entity => entity.EStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCenterWithMStatuesAsync(Center Center)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Center.Equals(Center)).Include(entity => entity.MStatuses).ToListAsync();
        }
        public async Task<List<TEntity>> GetToListByCenterWithSStatuesAsync(Center Center)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Center.Equals(Center)).Include(entity => entity.SStatuses).ToListAsync();
        }
        public async Task<List<TEntity>> GetToListByCenterWithRelatedStatusesAsync(Center Center)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Center.Equals(Center)).Include(entity => entity.SStatuses).
                                                                                        Include(entity => entity.MStatuses).
                                                                                        Include(entity => entity.EStatuses).
                                                                                        ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByHsCodeAsync(string HsCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.HsCode.Equals(HsCode)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByHsCodeWithEStatuesAsync(string HsCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.HsCode.Equals(HsCode)).Include(entity => entity.EStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByHsCodeWithMStatuesAsync(string HsCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.HsCode.Equals(HsCode)).Include(entity => entity.MStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByHsCodeWithRelatedStatusesAsync(string HsCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.HsCode.Equals(HsCode)).Include(entity => entity.EStatuses).
                                                                                            Include(entity => entity.MStatuses).
                                                                                            Include(entity => entity.SStatuses).
                                                                                            ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByHsCodeWithSStatuesAsync(string HsCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.HsCode.Equals(HsCode)).Include(entity => entity.SStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithEStatusesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.EStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithMStatusesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.MStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithSStatusesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.SStatuses).ToListAsync();
        }

        public async Task<bool> IsDuplecatedByNameAsync(TEntity entity)
        {
            TEntity FindEntity = await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.Name.Equals(entity.Name));
            if (FindEntity != null) { return true;  }
            else { return false;  }
        }

        public async Task<List<TEntity>> GetToListByUserIdWithSStatusAsyncstring (string UserId)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.UserId.Equals(UserId)).Include(e=>e.SStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCenterIdAsync(string CenterId)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.CenterId.Equals(CenterId)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByBarcodeAsync(string Barcode)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Barcode.Equals(Barcode)).ToListAsync();
        }
        public async Task<TEntity> GetByHsCodeAsnyc(string HsCode)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.HsCode.Equals(HsCode));
        }

        public async Task<TEntity> GetByCenterIdAsnyc(string CenterId)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.CenterId.Equals(CenterId));
        }

        public async Task<TEntity> GetByBarcodeWithRelatedAsync(string Barcode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Barcode.Equals(Barcode)).Include(e=>e.Center).Include(e=>e.SStatuses).Include(e=>e.MStatuses).Include(e=>e.EStatuses).FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetByHsCodeWithRelatedAsnyc(string HsCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.HsCode.Equals(HsCode)).Include(e=>e.Center).Include(e=>e.SStatuses).Include(e=>e.MStatuses).Include(e=>e.EStatuses).FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetByCenterIdWithRelatedAsnyc(string CenterId)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.CenterId.Equals(CenterId)).Include(e=>e.Center).Include(e=>e.SStatuses).Include(e=>e.MStatuses).Include(e=>e.EStatuses).FirstOrDefaultAsync();
        }

        public async Task<List<TEntity>> GetToListByHsCodeWithRelatedAsync(string HsCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.HsCode.Equals(HsCode)).Include(e=>e.Center).Include(e=>e.SStatuses).Include(e=>e.MStatuses).Include(e=>e.EStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCenterIdWithRelatedAsync(string CenterId)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.CenterId.Equals(CenterId)).Include(e=>e.Center).Include(e=>e.SStatuses).Include(e=>e.MStatuses).Include(e=>e.EStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByBarcodeWithRelatedAsync(string Barcode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Barcode.Equals(Barcode)).Include(e=>e.Center).Include(e=>e.SStatuses).Include(e=>e.MStatuses).Include(e=>e.EStatuses).ToListAsync();
        }
    }
}