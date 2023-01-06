using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofTrade.ofDbContext;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using System;

namespace BusinessData.ofDataAccessLayer.ofTrade.ofRepository
{
    public interface ITradeCenterRepository : ICenterDataRepository<TradeCenter>
    {
    
    }
    public interface ITCommodityRepository : ICommodityDataRepository<TCommodity>
    {

    }
    public interface ISTCommodityRepository : IStatusDataRepository<STCommodity>
    {

    }
    public interface IMTCommodityRepository : IStatusDataRepository<MTCommodity>
    {

    }
    public interface IETCommodityRepository : IStatusDataRepository<ETCommodity>
    {

    }   
    public class TradeCenterRepository : CenterDataRepository<TradeCenter>, ITradeCenterRepository
    {
        public TradeCenterRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
        public TradeCenterRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public class TCommodityRepository : CommodityDataRepository<TCommodity>, ITCommodityRepository
    {
        public TCommodityRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
        public TCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public class STCommodityRepository : StatusDataRepository<STCommodity>, ISTCommodityRepository
    {
        public STCommodityRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
        public STCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public class MTCommodityRepository : StatusDataRepository<MTCommodity>, IMTCommodityRepository
    {
        public MTCommodityRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
        public MTCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
    public class ETCommodityRepository : StatusDataRepository<ETCommodity>, IETCommodityRepository
    {
        public ETCommodityRepository(TradeDbContext TradeDbContext)
                : base(TradeDbContext)
        {

        }
        public ETCommodityRepository(Action<RepositoryOptions> options)
                : base(options)
        {

        }
    }
}