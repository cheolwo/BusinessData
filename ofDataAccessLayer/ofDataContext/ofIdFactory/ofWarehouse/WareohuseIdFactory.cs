using BusinessData.ofCommon.ofKapt;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofInterface;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofRepository;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofWarehouse.ofIdFactory
{
    public interface IWarehouseIdFactory : ICenterIdFactory<Warehouse>
    {
        Task<string> CreateByKapt(Warehouse warehouse, KAptBasicInfo kAptBasicInfo);
    }
    public class WarehouseIdFactory : CenterIdFactory<Warehouse>, IWarehouseIdFactory
    {
        public WarehouseIdFactory(IWarehouseRepository warehouseRepository)
            : base(warehouseRepository)
        {

        }
        public WarehouseIdFactory() { }
        public async Task<string> CreateByKapt(Warehouse warehouse, KAptBasicInfo kAptBasicInfo)
        {
            string Id = await base.CreateAsync(warehouse);        
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Id);
            stringBuilder.Append('-');
            stringBuilder.Append("KApt");
            stringBuilder.Append('-');
            stringBuilder.Append(kAptBasicInfo.Id);
            return stringBuilder.ToString();
        }
    }
    public interface IWCommodityIdFactory : ICommodityIdFactory<WCommodity>
    {

    }
    public class WCommodityIdFactory : CommodityIdFactory<WCommodity>, IWCommodityIdFactory
    {
        public WCommodityIdFactory(IWCommodityRepository WCommodityRepository)
            : base(WCommodityRepository)
        {

        }
        public WCommodityIdFactory()
        {

        }
    }
    public interface ISWCommodityIdFactory : IStatusIdFactory<SWCommodity>
    {

    }
    public class SWCommodityIdFactory : StatusIdFactory<SWCommodity>, ISWCommodityIdFactory
    {
        public SWCommodityIdFactory(ISWCommodityRepository SWCommodityRepository)
            : base(SWCommodityRepository)
        {

        }
        public SWCommodityIdFactory() { }
    }
    public interface IMWCommodityIdFactory : IStatusIdFactory<MWCommodity>
    {

    }
    public class MWCommodityIdFactory : StatusIdFactory<MWCommodity>, IMWCommodityIdFactory
    {
        public MWCommodityIdFactory(IMWCommodityRepository MWCommodityRepository)
            : base(MWCommodityRepository)
        {

        }
        public MWCommodityIdFactory() { }
    }
    public interface IEWCommodityIdFactory : IStatusIdFactory<EWCommodity>
    {

    }
    public class EWCommodityIdFactory : StatusIdFactory<EWCommodity>, IEWCommodityIdFactory
    {
        public EWCommodityIdFactory(IEWCommodityRepository EWCommodityRepository)
            : base(EWCommodityRepository)
        {

        }
        public EWCommodityIdFactory() { }
    }
    public interface IWorkingDeskIdFactory : IEntityIdFactory<WorkingDesk>
    {

    }
    public class WorkingDeskIdFactory : EntityIdFactory<WorkingDesk>, IWorkingDeskIdFactory
    {
        public WorkingDeskIdFactory(IWorkingDeskRepository WorkingDeskRepository)
            : base(WorkingDeskRepository)
        {

        }
        public WorkingDeskIdFactory() { }
    }
    public interface IDotBarcodeIdFactory : IEntityIdFactory<DotBarcode>
    {

    }
    public class DotBarcodeIdFactory : EntityIdFactory<DotBarcode>, IDotBarcodeIdFactory
    {
        public DotBarcodeIdFactory(IDotBarcodeRepository DotBarcodeRepository)
            : base(DotBarcodeRepository)
        {

        }
        public DotBarcodeIdFactory() { }
    }
    public interface IDividedTagIdFactory : IEntityIdFactory<DividedTag>
    {

    }
    public class DividedTagIdFactory : EntityIdFactory<DividedTag>, IDividedTagIdFactory
    {
        public DividedTagIdFactory(IDividedTagRepository DividedTagRepository)
            : base(DividedTagRepository)
        {

        }
        public DividedTagIdFactory() { }
    }
    public interface IIncomingTagIdFactory : IEntityIdFactory<IncomingTag>
    {

    }
    public class IncomingTagIdFactory : EntityIdFactory<IncomingTag>, IIncomingTagIdFactory
    {
        public IncomingTagIdFactory(IIncomingTagRepository IncomingTagRepository)
            : base(IncomingTagRepository)
        {

        }
        public IncomingTagIdFactory() { }
    }
    public interface ILoadFrameIdFactory : IEntityIdFactory<LoadFrame>
    {

    }
    public class LoadFrameIdFactory : EntityIdFactory<LoadFrame>, ILoadFrameIdFactory
    {
        public LoadFrameIdFactory(ILoadFrameRepository LoadFrameRepository)
            : base(LoadFrameRepository)
        {

        }
        public LoadFrameIdFactory() { }
    }

}