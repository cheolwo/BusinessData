using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofEntityManager.ofDeliveryCenter.ofFileFactory
{
    public interface IMarketFileFactory : ICenterFileFactory<Market>
    {

    }
    public class MarketFileFactory : CenterFileFactory<Market>, IMarketFileFactory
    {

    }
    public interface IMCommodityFileFactory : ICommodityFileFactory<MCommodity>
    {

    }
    public class MCommodityFileFactory : CommodityFileFactory<MCommodity>, IMCommodityFileFactory
    {

    }
    public interface ISMCommodityFileFactory : IStatusFileFactory<SMCommodity>
    {

    }
    public class SMCommodityFileFactory : StatusFileFactory<SMCommodity>, ISMCommodityFileFactory
    {

    }
    public interface IMMCommodityFileFactory : IStatusFileFactory<MMCommodity>
    {

    }
    public class MMCommodityFileFactory : StatusFileFactory<MMCommodity>, IMMCommodityFileFactory
    {

    }
    public interface IEMCommodityFileFactory : IStatusFileFactory<EMCommodity>
    {

    }
    public class EMCommodityFileFactory : StatusFileFactory<EMCommodity>, IEMCommodityFileFactory
    {

    }
}