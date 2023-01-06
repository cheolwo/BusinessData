using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofEntityManager.ofTrade.ofFileFactory
{
    public interface ITradeCenterFileFactory : ICenterFileFactory<TradeCenter>
    {

    }
    public class TradeCenterFileFactory : CenterFileFactory<TradeCenter>, ITradeCenterFileFactory
    {

    }
    public interface ITCommodityFileFactory : ICommodityFileFactory<TCommodity>
    {

    }
    public class TCommodityFileFactory : CommodityFileFactory<TCommodity>, ITCommodityFileFactory
    {

    }
    public interface ISTCommodityFileFactory : IStatusFileFactory<STCommodity>
    {

    }
    public class STCommodityFileFactory : StatusFileFactory<STCommodity>, ISTCommodityFileFactory
    {

    }
    public interface IMTCommodityFileFactory : IStatusFileFactory<MTCommodity>
    {

    }
    public class MTCommodityFileFactory : StatusFileFactory<MTCommodity>, IMTCommodityFileFactory
    {

    }
    public interface IETCommodityFileFactory : IStatusFileFactory<ETCommodity>
    {

    }
    public class ETCommodityFileFactory : StatusFileFactory<ETCommodity>, IETCommodityFileFactory
    {

    }
}