using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessData.ofDataAccessLayer.ofTrade.ofRepository;

namespace BusinessLogic.ofEntityManager.ofTrade.ofIdFactory
{
    public interface ITradeCenterIdFactory : ICenterIdFactory<TradeCenter>
    {

    }
    public class TradeCenterIdFactory : CenterIdFactory<TradeCenter>, ITradeCenterIdFactory
    {
        public TradeCenterIdFactory(ITradeCenterRepository TradeCenterRepository)
            : base(TradeCenterRepository)
        {

        }
    }
    public interface ITCommodityIdFactory : ICommodityIdFactory<TCommodity>
    {

    }
    public class TCommodityIdFactory : CommodityIdFactory<TCommodity>, ITCommodityIdFactory
    {
        public TCommodityIdFactory(ITCommodityRepository TCommodityRepository)
            : base(TCommodityRepository)
        {

        }
    }
    public interface ISTCommodityIdFactory : IStatusIdFactory<STCommodity>
    {

    }
    public class STCommodityIdFactory : StatusIdFactory<STCommodity>, ISTCommodityIdFactory
    {
        public STCommodityIdFactory(ISTCommodityRepository STCommodityRepository)
            : base(STCommodityRepository)
        {

        }
    }
    public interface IMTCommodityIdFactory : IStatusIdFactory<MTCommodity>
    {

    }
    public class MTCommodityIdFactory : StatusIdFactory<MTCommodity>, IMTCommodityIdFactory
    {
        public MTCommodityIdFactory(IMTCommodityRepository MTCommodityRepository)
            : base(MTCommodityRepository)
        {

        }
    }
    public interface IETCommodityIdFactory : IStatusIdFactory<ETCommodity>
    {

    }
    public class ETCommodityIdFactory : StatusIdFactory<ETCommodity>, IETCommodityIdFactory
    {
        public ETCommodityIdFactory(IETCommodityRepository ETCommodityRepository)
            : base(ETCommodityRepository)
        {

        }
    }
}