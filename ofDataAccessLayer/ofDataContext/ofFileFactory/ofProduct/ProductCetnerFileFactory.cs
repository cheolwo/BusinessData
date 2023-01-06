using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofProduct;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofEntityManager.ofProduct.ofFileFactory
{
    public interface IProductCenterFileFactory : ICenterFileFactory<ProductCenter>
    {

    }
    public class ProductCenterFileFactory : CenterFileFactory<ProductCenter>, IProductCenterFileFactory
    {

    }
    public interface IPCommodityFileFactory : ICommodityFileFactory<PCommodity>
    {

    }
    public class PCommodityFileFactory : CommodityFileFactory<PCommodity>, IPCommodityFileFactory
    {

    }
    public interface ISPCommodityFileFactory : IStatusFileFactory<SPCommodity>
    {

    }
    public class SPCommodityFileFactory : StatusFileFactory<SPCommodity>, ISPCommodityFileFactory
    {

    }
    public interface IMPCommodityFileFactory : IStatusFileFactory<MPCommodity>
    {

    }
    public class MPCommodityFileFactory : StatusFileFactory<MPCommodity>, IMPCommodityFileFactory
    {

    }
    public interface IEPCommodityFileFactory : IStatusFileFactory<EPCommodity>
    {

    }
    public class EPCommodityFileFactory : StatusFileFactory<EPCommodity>, IEPCommodityFileFactory
    {

    }
}