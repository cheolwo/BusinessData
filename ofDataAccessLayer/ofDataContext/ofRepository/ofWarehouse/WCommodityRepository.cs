using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofInterface;
using System;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.ofRepository
{
    public class WCommodityRepository : CommodityDataRepository<WCommodity>, IWCommodityRepository
    {
        public WCommodityRepository(WarehouseDbContext BusinessDataContext)
                : base(BusinessDataContext)
        {

        }
        public WCommodityRepository(Action<RepositoryOptions> options)
            :base(options)
        {
           
        }
        public async Task<List<WCommodity>> GetToListByWarehouseWithStatusAsync(Warehouse warehouse)
        {
            return await _DbContext.Set<WCommodity>()
                                                    .Include(WCommodity => WCommodity.SWCommodities)
                                                    .Include(WCommodity => WCommodity.MWCommodities)
                                                    .Include(WCommodity => WCommodity.EWCommodities)
                                                    .ToListAsync();
        } 

        public async Task<List<WCommodity>> GetToListByWarehouseAsync(Warehouse warehouse)
        {
            return await _DbContext.Set<WCommodity>().Where(e=>e.Warehouse.Equals(warehouse)).ToListAsync();
        }
    }
}