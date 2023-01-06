using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofInterface;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofWarehouse.ofBlobStorage
{
    public interface IWCommodityBlobContainerFactory : IEntityContainerFactory<WCommodity>
    {

    }
    public interface ISWCommodityBlobContainerFactory : IEntityContainerFactory<SWCommodity>
    {

    }
    public interface IMWCommodityBlobContainerFactory : IEntityContainerFactory<MWCommodity>
    {

    }
    public interface IEWCommodityBlobContainerFactory : IEntityContainerFactory<EWCommodity>
    {

    }
    public interface IWarehouseBlobContainerFactory : IEntityContainerFactory<Warehouse>
    {

    }
    public class WarehouseBlobContainerFactory : EntityContainerFactory<Warehouse>, IWarehouseBlobContainerFactory
    {
        public WarehouseBlobContainerFactory(IWarehouseRepository warehouseRepository)
                :base(warehouseRepository)
        {
            
        }
        public override async Task<string> CreateNameofContainer(Warehouse entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class WCommodityBlobContainerFactory : EntityContainerFactory<WCommodity>, IWCommodityBlobContainerFactory
    {
        public WCommodityBlobContainerFactory(IWCommodityRepository WCommodityRepository)
                :base(WCommodityRepository)
        {
            
        }
    }
    public class SWCommodityBlobContainerFactory : EntityContainerFactory<SWCommodity>, ISWCommodityBlobContainerFactory
    {
        public SWCommodityBlobContainerFactory(ISWCommodityRepository SWCommodityRepository)
                :base(SWCommodityRepository)
        {
            
        }
    }
    public class MWCommodityBlobContainerFactory : EntityContainerFactory<MWCommodity>, IMWCommodityBlobContainerFactory
    {
        public MWCommodityBlobContainerFactory(IMWCommodityRepository MWCommodityRepository)
                :base(MWCommodityRepository)
        {
            
        }
    }
    public class EWCommodityBlobContainerFactory : EntityContainerFactory<EWCommodity>, IEWCommodityBlobContainerFactory
    {
        public EWCommodityBlobContainerFactory(IEWCommodityRepository EWCommodityRepository)
                :base(EWCommodityRepository)
        {
            
        }
    }

    public interface IDividedTagBlobContainerFactory : IEntityContainerFactory<DividedTag>
    {

    }
    public class DividedTagBlobContainerFactory : EntityContainerFactory<DividedTag>, IDividedTagBlobContainerFactory
    {
        public DividedTagBlobContainerFactory(IDividedTagRepository DividedTagRepository)
                :base(DividedTagRepository)
        {
            
        }
    }
    public interface IDotBarcodeBlobContainerFactory : IEntityContainerFactory<DotBarcode>
    {

    }
    public class DotBarcodeBlobContainerFactory : EntityContainerFactory<DotBarcode>, IDotBarcodeBlobContainerFactory
    {
        public DotBarcodeBlobContainerFactory(IDotBarcodeRepository DotBarcodeRepository)
                :base(DotBarcodeRepository)
        {
            
        }
    }
    public interface IIncomingTagBlobContainerFactory : IEntityContainerFactory<IncomingTag>
    {

    }
    public class IncomingTagBlobContainerFactory : EntityContainerFactory<IncomingTag>, IIncomingTagBlobContainerFactory
    {
        public IncomingTagBlobContainerFactory(IIncomingTagRepository IncomingTagRepository)
                :base(IncomingTagRepository)
        {
            
        }
    }
    public interface ILoadFrameBlobContainerFactory : IEntityContainerFactory<LoadFrame>
    {

    }
    public class LoadFrameBlobContainerFactory : EntityContainerFactory<LoadFrame>, ILoadFrameBlobContainerFactory
    {
        public LoadFrameBlobContainerFactory(ILoadFrameRepository LoadFrameRepository)
                :base(LoadFrameRepository)
        {
            
        }
    }
    public interface IWorkingDeskBlobContainerFactory : IEntityContainerFactory<WorkingDesk>
    {

    }
    public class WorkingDeskBlobContainerFactory : EntityContainerFactory<WorkingDesk>, IWorkingDeskBlobContainerFactory
    {
        public WorkingDeskBlobContainerFactory(IWorkingDeskRepository WorkingDeskRepository)
                :base(WorkingDeskRepository)
        {
            
        }
    }

    public interface IWCommodityBlobStorage : IEntityBlobStorage<WCommodity>
    {

    }
    public interface ISWCommodityBlobStorage : IEntityBlobStorage<SWCommodity>
    {

    }
    public interface IMWCommodityBlobStorage : IEntityBlobStorage<MWCommodity>
    {

    }
    public interface IEWCommodityBlobStorage : IEntityBlobStorage<EWCommodity>
    {

    }
    public interface IWarehouseBlobStorage : IEntityBlobStorage<Warehouse>
    {

    }
    public class WCommodityBlobStorage : EntityBlobStorage<WCommodity>, IWCommodityBlobStorage
    {
        public WCommodityBlobStorage(IWCommodityBlobContainerFactory WCommodityBlobContainerFactory)
            : base(WCommodityBlobContainerFactory)
        {

        }
    }
    public class SWCommodityBlobStorage : EntityBlobStorage<SWCommodity>, ISWCommodityBlobStorage
    {
        public SWCommodityBlobStorage(ISWCommodityBlobContainerFactory SWCommodityBlobContainerFactory)
            : base(SWCommodityBlobContainerFactory)
        {

        }

    }
    public class MWCommodityBlobStorage : EntityBlobStorage<MWCommodity>, IMWCommodityBlobStorage
    {
        public MWCommodityBlobStorage(IMWCommodityBlobContainerFactory MWCommodityBlobContainerFactory)
            : base(MWCommodityBlobContainerFactory)
        {

        }
    }
    public class EWCommodityBlobStorage : EntityBlobStorage<EWCommodity>, IEWCommodityBlobStorage
    {
        public EWCommodityBlobStorage(IEWCommodityBlobContainerFactory EWCommodityBlobContainerFactory)
            : base(EWCommodityBlobContainerFactory)
        {

        }
    }
    public class WarehouseBlobStorage : EntityBlobStorage<Warehouse>, IWarehouseBlobStorage
    {
        public WarehouseBlobStorage(IWarehouseBlobContainerFactory WarehouseBlobContainerFactory)
            : base(WarehouseBlobContainerFactory)
        {

        }
    }
    public interface IDividedTagBlobStorage : IEntityBlobStorage<DividedTag>
    {

    }
    public class DividedTagBlobStorage : EntityBlobStorage<DividedTag>, IDividedTagBlobStorage
    {
        public DividedTagBlobStorage(IDividedTagBlobContainerFactory DividedTagBlobContainerFactory)
            : base(DividedTagBlobContainerFactory)
        {

        }
    }
    public interface IDotBarcodeBlobStorage : IEntityBlobStorage<DotBarcode>
    {

    }
    public class DotBarcodeBlobStorage : EntityBlobStorage<DotBarcode>, IDotBarcodeBlobStorage
    {
        public DotBarcodeBlobStorage(IDotBarcodeBlobContainerFactory DotBarcodeBlobContainerFactory)
            : base(DotBarcodeBlobContainerFactory)
        {

        }
    }
    public interface IIncomingTagBlobStorage : IEntityBlobStorage<IncomingTag>
    {

    }
    public class IncomingTagBlobStorage : EntityBlobStorage<IncomingTag>, IIncomingTagBlobStorage
    {
        public IncomingTagBlobStorage(IIncomingTagBlobContainerFactory IncomingTagBlobContainerFactory)
            : base(IncomingTagBlobContainerFactory)
        {

        }
    }
    public interface ILoadFrameBlobStorage : IEntityBlobStorage<LoadFrame>
    {

    }
    public class LoadFrameBlobStorage : EntityBlobStorage<LoadFrame>, ILoadFrameBlobStorage
    {
        public LoadFrameBlobStorage(ILoadFrameBlobContainerFactory LoadFrameBlobContainerFactory)
            : base(LoadFrameBlobContainerFactory)
        {

        }
    }
    public interface IWorkingDeskBlobStorage : IEntityBlobStorage<WorkingDesk>
    {

    }
    public class WorkingDeskBlobStorage : EntityBlobStorage<WorkingDesk>, IWorkingDeskBlobStorage
    {
        public WorkingDeskBlobStorage(IWorkingDeskBlobContainerFactory WorkingDeskBlobContainerFactory)
            : base(WorkingDeskBlobContainerFactory)
        {

        }
    }
}