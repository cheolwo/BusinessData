using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofMarket.ofDbContext;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using Microsoft.EntityFrameworkCore;
using System;

namespace BusinessData.ofDataAccessLayer.ofMarket.ofRepository
{
    public interface IMarketRepository<TMarket> : ICenterDataRepository<TMarket> where TMarket : Market, new()
    {

    }
    public interface IPlatMarketRepository<TPlatMarket> : ICenterDataRepository<TPlatMarket> where TPlatMarket : PlatMarket, new()
    {

    }
    public interface IMCommodityRepository<TMCommodity> : ICommodityDataRepository<TMCommodity> where TMCommodity : MCommodity, new()
    {

    }
    public interface ISMCommodityRepository<TSMCommodity> : ISStatusDataRepository<TSMCommodity> where TSMCommodity : SMCommodity, new()
    {

    }
    public interface IMMCommodityRepository<TMMCommodity> : IMStatusDataRepository<TMMCommodity> where TMMCommodity : MMCommodity, new()
    {

    }
    public interface IEMCommodityRepository<TEMCommodity> : IEStatusDataRepository<TEMCommodity> where TEMCommodity : EMCommodity, new()
    {

    }
    public class PlatMarketRepository<TPlatMarket> : CenterDataRepository<TPlatMarket>, IPlatMarketRepository<TPlatMarket> where TPlatMarket : PlatMarket, new()
    {
        public PlatMarketRepository(DbContext DbContext)
                : base(DbContext)
        {

        }
    }
    public class MarketRepository<TMarket> : CenterDataRepository<TMarket>, IMarketRepository<TMarket> where TMarket : Market, new()
    {
        public MarketRepository(DbContext DbContext)
                : base(DbContext)
        {

        }
    }
    public class MCommodityRepository<TMCommodity> : CommodityDataRepository<TMCommodity>, IMCommodityRepository<TMCommodity> where TMCommodity : MCommodity, new()
    {
        public MCommodityRepository(DbContext DbContext)
                : base(DbContext)
        {

        }
    }
    public class SMCommodityRepository<TSMCommodity> : SStatusDataRepository<TSMCommodity>, ISMCommodityRepository<TSMCommodity> where TSMCommodity : SMCommodity, new()
    {
        public SMCommodityRepository(DbContext DbContext)
                : base(DbContext)
        {

        }
    }
    public class MMCommodityRepository<TMMCommodity> : MStatusDataRepository<TMMCommodity>, IMMCommodityRepository<TMMCommodity> where TMMCommodity : MMCommodity, new()
    {
        public MMCommodityRepository(DbContext DbContext)
                : base(DbContext)
        {

        }
    }
    public class EMCommodityRepository<TEMCommodity> : EStatusDataRepository<TEMCommodity>, IEMCommodityRepository<TEMCommodity> where TEMCommodity : EMCommodity, new()
    {
        public EMCommodityRepository(DbContext DbContext)
                : base(DbContext)
        {

        }
    }
}