using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofInterface;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.ofRepository
{
    public class WarehouseRepository : CenterDataRepository<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(WarehouseDbContext WarehouseDbContext)
                : base(WarehouseDbContext)
        {

        }
        public WarehouseRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
        public async Task<List<Warehouse>> GetToListByUserIdWithWCommodityAsync(string UserId)
        {
            List<Warehouse> Warehouses = await _DbContext.Set<Warehouse>()
                                            .Where(e => e.UserId.Equals(UserId))
                                            .Include(Warehouse => Warehouse.WCommodities)
                                            .ToListAsync();
            return Warehouses;
        }
        public new async Task<Warehouse> GetByNameAsync(string Name)
        {
            return await _DbContext.Set<Warehouse>().FirstOrDefaultAsync(e => e.Name.Equals(Name));
        }

        public async Task<Warehouse> GetRelatedData(Warehouse warehouse)
        {
            if (warehouse != null)
            {
                Warehouse WithRelatedWarehouse = await _DbContext.Set<Warehouse>()
                                                .Where(e => e.Id.Equals(warehouse.Id))
                                                .Include(Warehouse => Warehouse.WCommodities)
                                                .Include(Warehouse => Warehouse.SWCommodities)
                                                .Include(Warehouse => Warehouse.MWCommodities)
                                                .Include(Warehouse => Warehouse.EWCommodities)
                                                .Include(Warehouse => Warehouse.LoadFrames)
                                                .Include(Warehouse => Warehouse.DotBarcodes)
                                                .Include(Warehouse => Warehouse.WorkingDesks)
                                                .Include(Warehouse => Warehouse.DividedTags)
                                                .Include(Warehouse => Warehouse.IncomingTags).FirstOrDefaultAsync();

                return WithRelatedWarehouse;
            }
            else {throw new ArgumentNullException();}
        }
    }

    public class SWCommodityRepository : StatusDataRepository<SWCommodity>, ISWCommodityRepository
    {
        public SWCommodityRepository(WarehouseDbContext WarehouseDbContext)
                : base(WarehouseDbContext)
        {

        }
        public SWCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
        public async Task<List<SWCommodity>> GetToListByWCommodityWithStatusAsync(WCommodity wCommodity)
        {
            List<SWCommodity> SWCommodities = await _DbContext.Set<SWCommodity>()
                                                        .Include(SWCommodity => SWCommodity.MWCommodities)
                                                        .ThenInclude(MWCommodity => MWCommodity.EWCommodities)
                                                        .ToListAsync();
            return SWCommodities;
        }

        public async Task<List<SWCommodity>> GetToListByWarehouseAsync(Warehouse warehouse)
        {
            return await _DbContext.Set<SWCommodity>().Where(e => e.Warehouse.Equals(warehouse)).ToListAsync();
        }

    }

    public class MWCommodityRepository : StatusDataRepository<MWCommodity>, IMWCommodityRepository
    {
        public MWCommodityRepository(WarehouseDbContext WarehouseDbContext)
                : base(WarehouseDbContext)
        {

        }
        public MWCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
        public async Task<List<MWCommodity>> GetToListByWarehouseAsync(Warehouse warehouse)
        {
            return await _DbContext.Set<MWCommodity>().Where(e => e.Warehouse.Equals(warehouse)).ToListAsync();
        }

    }

    public class EWCommodityRepository : StatusDataRepository<EWCommodity>, IEWCommodityRepository
    {
        public EWCommodityRepository(WarehouseDbContext WarehouseDbContext)
                : base(WarehouseDbContext)
        {

        }
        public EWCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
        public async Task<List<EWCommodity>> GetToListByWarehouseAsync(Warehouse warehouse)
        {
            return await _DbContext.Set<EWCommodity>().Where(e => e.Warehouse.Equals(warehouse)).ToListAsync();
        }
    }
    public interface IWorkingDeskRepository : IEntityDataRepository<WorkingDesk>
    {

    }
    public class WorkingDeskRepository : EntityDataRepository<WorkingDesk>, IWorkingDeskRepository
    {
        public WorkingDeskRepository(WarehouseDbContext warehouseDbContext)
            : base(warehouseDbContext)
        {

        }
        public WorkingDeskRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public interface IDotBarcodeRepository : IEntityDataRepository<DotBarcode>
    {

    }
    public class DotBarcodeRepository : EntityDataRepository<DotBarcode>, IDotBarcodeRepository
    {
        public DotBarcodeRepository(WarehouseDbContext warehouseDbContext)
            : base(warehouseDbContext)
        {

        }
        public DotBarcodeRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public interface IIncomingTagRepository : IEntityDataRepository<IncomingTag>
    {

    }
    public class IncomingTagRepository : EntityDataRepository<IncomingTag>, IIncomingTagRepository
    {
        public IncomingTagRepository(WarehouseDbContext warehouseDbContext)
            : base(warehouseDbContext)
        {

        }
        public IncomingTagRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public interface IDividedTagRepository : IEntityDataRepository<DividedTag>
    {

    }
    public class DividedTagRepository : EntityDataRepository<DividedTag>, IDividedTagRepository
    {
        public DividedTagRepository(WarehouseDbContext warehouseDbContext)
            : base(warehouseDbContext)
        {

        }
        public DividedTagRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public interface ILoadFrameRepository : IEntityDataRepository<LoadFrame>
    {

    }
    public class LoadFrameRepository : EntityDataRepository<LoadFrame>, ILoadFrameRepository
    {
        public LoadFrameRepository(WarehouseDbContext warehouseDbContext)
            : base(warehouseDbContext)
        {

        }
        public LoadFrameRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
}