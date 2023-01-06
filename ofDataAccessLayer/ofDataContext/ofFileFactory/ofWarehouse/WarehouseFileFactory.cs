using BusinessData.ofDataAccessLayer.ofWarehouse.Model;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofEntityManager.ofWarehouse.ofFileFactory
{
    public interface IWarehouseFileFactory : ICenterFileFactory<Warehouse>
    {

    }
    public class WarehouseFileFactory : CenterFileFactory<Warehouse>, IWarehouseFileFactory
    {

    }
    public interface IWCommodityFileFactory : ICommodityFileFactory<WCommodity>
    {

    }
    public class WCommodityFileFactory : CommodityFileFactory<WCommodity>, IWCommodityFileFactory
    {

    }
    public interface ISWCommodityFileFactory : IStatusFileFactory<SWCommodity>
    {

    }
    public class SWCommodityFileFactory : StatusFileFactory<SWCommodity>, ISWCommodityFileFactory
    {

    }
    public interface IMWCommodityFileFactory : IStatusFileFactory<MWCommodity>
    {

    }
    public class MWCommodityFileFactory : StatusFileFactory<MWCommodity>, IMWCommodityFileFactory
    {

    }
    public interface IEWCommodityFileFactory : IStatusFileFactory<EWCommodity>
    {

    }
    public class EWCommodityFileFactory : StatusFileFactory<EWCommodity>, IEWCommodityFileFactory
    {

    }
    public interface IWorkingDeskFileFactory : IEntityFileFactory<WorkingDesk>
    {

    }
    public class WorkingDeskFileFactory : EntityFileFactory<WorkingDesk>, IWorkingDeskFileFactory
    {

    }
    public interface IDotBarcodeFileFactory : IEntityFileFactory<DotBarcode>
    {

    }
    public class DotBarcodeFileFactory : EntityFileFactory<DotBarcode>, IDotBarcodeFileFactory
    {

    }
    public interface IIncomingTagFileFactory : IEntityFileFactory<IncomingTag>
    {

    }
    public class IncomingTagFileFactory : EntityFileFactory<IncomingTag>, IIncomingTagFileFactory
    {

    }
    public interface ILoadFrameFileFactory : IEntityFileFactory<LoadFrame>
    {

    }
    public class LoadFrameFileFactory : EntityFileFactory<LoadFrame>, ILoadFrameFileFactory
    {

    }
    public interface IDividedTagFileFactory : IEntityFileFactory<DividedTag>
    {

    }
    public class DividedTagFileFactory : EntityFileFactory<DividedTag>, IDividedTagFileFactory
    {

    }
}