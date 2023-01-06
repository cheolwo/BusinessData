using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofEntityManager.ofOrder.ofFileFactory
{
    public interface IOrderCenterFileFactory : ICenterFileFactory<OrderCenter>
    {

    }
    public class OrderCenterFileFactory : CenterFileFactory<OrderCenter>, IOrderCenterFileFactory
    {

    }
    public interface IOCommodityFileFactory : ICommodityFileFactory<OCommodity>
    {

    }
    public class OCommodityFileFactory : CommodityFileFactory<OCommodity>, IOCommodityFileFactory
    {

    }
    public interface ISOCommodityFileFactory : IStatusFileFactory<SOCommodity>
    {

    }
    public class SOCommodityFileFactory : StatusFileFactory<SOCommodity>, ISOCommodityFileFactory
    {

    }
    public interface IMOCommodityFileFactory : IStatusFileFactory<MOCommodity>
    {

    }
    public class MOCommodityFileFactory : StatusFileFactory<MOCommodity>, IMOCommodityFileFactory
    {

    }
    public interface IEOCommodityFileFactory : IStatusFileFactory<EOCommodity>
    {

    }
    public class EOCommodityFileFactory : StatusFileFactory<EOCommodity>, IEOCommodityFileFactory
    {

    }
}