using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using BusinessData.ofDataAccessLayer.ofTrade.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofTrade.ofBlobStorage
{
    public interface ITCommodityBlobContainerFactory : IEntityContainerFactory<TCommodity>
    {

    }
    public interface ISTCommodityBlobContainerFactory : IEntityContainerFactory<STCommodity>
    {

    }
    public interface IMTCommodityBlobContainerFactory : IEntityContainerFactory<MTCommodity>
    {

    }
    public interface IETCommodityBlobContainerFactory : IEntityContainerFactory<ETCommodity>
    {

    }
    public interface ITradeCenterBlobContainerFactory : IEntityContainerFactory<TradeCenter>
    {

    }
    public class TradeCenterBlobContainerFactory : EntityContainerFactory<TradeCenter>, ITradeCenterBlobContainerFactory
    {
        private readonly ITradeCenterRepository _TradeCenterRepository;
        public TradeCenterBlobContainerFactory(ITradeCenterRepository TradeCenterRepository)
                :base(TradeCenterRepository)
        {
            _TradeCenterRepository = TradeCenterRepository;
        }
        public override async Task<string> CreateNameofContainer(TradeCenter entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class TCommodityBlobContainerFactory : EntityContainerFactory<TCommodity>, ITCommodityBlobContainerFactory
    {
        private readonly ITCommodityRepository _TCommodityRepository;
        public TCommodityBlobContainerFactory(ITCommodityRepository TCommodityRepository)
                :base(TCommodityRepository)
        {
            _TCommodityRepository = TCommodityRepository;
        }
        public override async Task<string> CreateNameofContainer(TCommodity entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class STCommodityBlobContainerFactory : EntityContainerFactory<STCommodity>, ISTCommodityBlobContainerFactory
    {
        private readonly ISTCommodityRepository _STCommodityRepository;
        public STCommodityBlobContainerFactory(ISTCommodityRepository STCommodityRepository)
                :base(STCommodityRepository)
        {
            _STCommodityRepository = STCommodityRepository;
        }
        public override async Task<string> CreateNameofContainer(STCommodity entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class MTCommodityBlobContainerFactory : EntityContainerFactory<MTCommodity>, IMTCommodityBlobContainerFactory
    {
        private readonly IMTCommodityRepository _MTCommodityRepository;
        public MTCommodityBlobContainerFactory(IMTCommodityRepository MTCommodityRepository)
                :base(MTCommodityRepository)
        {
            _MTCommodityRepository = MTCommodityRepository;
        }
        public override async Task<string> CreateNameofContainer(MTCommodity entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class ETCommodityBlobContainerFactory : EntityContainerFactory<ETCommodity>, IETCommodityBlobContainerFactory
    {
        private readonly IETCommodityRepository _ETCommodityRepository;
        public ETCommodityBlobContainerFactory(IETCommodityRepository ETCommodityRepository)
                :base(ETCommodityRepository)
        {
            _ETCommodityRepository = ETCommodityRepository;
        }
        public override async Task<string> CreateNameofContainer(ETCommodity entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface ITCommodityBlobStorage : IEntityBlobStorage<TCommodity>
    {

    }
    public interface ISTCommodityBlobStorage : IEntityBlobStorage<STCommodity>
    {

    }
    public interface IMTCommodityBlobStorage : IEntityBlobStorage<MTCommodity>
    {

    }
    public interface IETCommodityBlobStorage : IEntityBlobStorage<ETCommodity>
    {

    }
    public interface ITradeCenterBlobStorage : IEntityBlobStorage<TradeCenter>
    {

    }
    public class TCommodityBlobStorage : EntityBlobStorage<TCommodity>, ITCommodityBlobStorage
    {
        public TCommodityBlobStorage(ITCommodityBlobContainerFactory TCommodityBlobContainerFactory)
            : base(TCommodityBlobContainerFactory)
        {

        }
    }
    public class STCommodityBlobStorage : EntityBlobStorage<STCommodity>, ISTCommodityBlobStorage
    {
        public STCommodityBlobStorage(ISTCommodityBlobContainerFactory STCommodityBlobContainerFactory)
            : base(STCommodityBlobContainerFactory)
        {

        }

    }
    public class MTCommodityBlobStorage : EntityBlobStorage<MTCommodity>, IMTCommodityBlobStorage
    {
        public MTCommodityBlobStorage(IMTCommodityBlobContainerFactory MTCommodityBlobContainerFactory)
            : base(MTCommodityBlobContainerFactory)
        {

        }
    }
    public class ETCommodityBlobStorage : EntityBlobStorage<ETCommodity>, IETCommodityBlobStorage
    {
        public ETCommodityBlobStorage(IETCommodityBlobContainerFactory ETCommodityBlobContainerFactory)
            : base(ETCommodityBlobContainerFactory)
        {

        }
    }
    public class TradeCenterBlobStorage : EntityBlobStorage<TradeCenter>, ITradeCenterBlobStorage
    {
        public TradeCenterBlobStorage(ITradeCenterBlobContainerFactory TradeCenterBlobContainerFactory)
            : base(TradeCenterBlobContainerFactory)
        {

        }
    }
}