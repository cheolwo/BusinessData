using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofDataAccessLayer.ofMarket.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofMarket.ofBlobStorage
{
    public interface IMCommodityBlobContainerFactory : IEntityContainerFactory<MCommodity>
    {

    }
    public interface ISMCommodityBlobContainerFactory : IEntityContainerFactory<SMCommodity>
    {

    }
    public interface IMMCommodityBlobContainerFactory : IEntityContainerFactory<MMCommodity>
    {

    }
    public interface IEMCommodityBlobContainerFactory : IEntityContainerFactory<EMCommodity>
    {

    }
    public interface IMarketBlobContainerFactory : IEntityContainerFactory<Market>
    {

    }
    public class MarketBlobContainerFactory : EntityContainerFactory<Market>, IMarketBlobContainerFactory
    {
        private readonly IMarketRepository<Market> _MarketRepository;
        public MarketBlobContainerFactory(IMarketRepository<Market> MarketRepository)
                :base(MarketRepository)
        {
            _MarketRepository = MarketRepository;
        }
        public override async Task<string> CreateNameofContainer(Market entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface IMCommodityBlobStorage : IEntityBlobStorage<MCommodity>
    {

    }
    public interface ISMCommodityBlobStorage : IEntityBlobStorage<SMCommodity>
    {

    }
    public interface IMMCommodityBlobStorage : IEntityBlobStorage<MMCommodity>
    {

    }
    public interface IEMCommodityBlobStorage : IEntityBlobStorage<EMCommodity>
    {

    }
    public interface IMarketBlobStorage : IEntityBlobStorage<Market>
    {

    }
    public class MCommodityBlobStorage : EntityBlobStorage<MCommodity>, IMCommodityBlobStorage
    {
        public MCommodityBlobStorage(IMCommodityBlobContainerFactory MCommodityBlobContainerFactory)
            : base(MCommodityBlobContainerFactory)
        {

        }
    }
    public class SMCommodityBlobStorage : EntityBlobStorage<SMCommodity>, ISMCommodityBlobStorage
    {
        public SMCommodityBlobStorage(ISMCommodityBlobContainerFactory SMCommodityBlobContainerFactory)
            : base(SMCommodityBlobContainerFactory)
        {

        }

    }
    public class MMCommodityBlobStorage : EntityBlobStorage<MMCommodity>, IMMCommodityBlobStorage
    {
        public MMCommodityBlobStorage(IMMCommodityBlobContainerFactory MMCommodityBlobContainerFactory)
            : base(MMCommodityBlobContainerFactory)
        {

        }
    }
    public class EMCommodityBlobStorage : EntityBlobStorage<EMCommodity>, IEMCommodityBlobStorage
    {
        public EMCommodityBlobStorage(IEMCommodityBlobContainerFactory EMCommodityBlobContainerFactory)
            : base(EMCommodityBlobContainerFactory)
        {

        }
    }
    public class MarketBlobStorage : EntityBlobStorage<Market>, IMarketBlobStorage
    {
        public MarketBlobStorage(IMarketBlobContainerFactory MarketBlobContainerFactory)
            : base(MarketBlobContainerFactory)
        {

        }
    }
}