using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofDataAccessLayer.ofOrder.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofOrder.ofBlobStorage
{
    public interface IOCommodityBlobContainerFactory : IEntityContainerFactory<OCommodity>
    {

    }
    public interface ISOCommodityBlobContainerFactory : IEntityContainerFactory<SOCommodity>
    {

    }
    public interface IMOCommodityBlobContainerFactory : IEntityContainerFactory<MOCommodity>
    {

    }
    public interface IEOCommodityBlobContainerFactory : IEntityContainerFactory<EOCommodity>
    {

    }
    public interface IOrderCenterBlobContainerFactory : IEntityContainerFactory<OrderCenter>
    {

    }
    public class OrderCenterBlobContainerFactory : EntityContainerFactory<OrderCenter>, IOrderCenterBlobContainerFactory
    {
        private readonly IOrderCenterRepository _OrderCenterRepository;
        public OrderCenterBlobContainerFactory(IOrderCenterRepository OrderCenterRepository)
                :base(OrderCenterRepository)
        {
            _OrderCenterRepository = OrderCenterRepository;
        }
        public override async Task<string> CreateNameofContainer(OrderCenter entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class OCommodityBlobContainerFactory : EntityContainerFactory<OCommodity>, IOCommodityBlobContainerFactory
    {
        private readonly IOCommodityRepository _OCommodityRepository;
        public OCommodityBlobContainerFactory(IOCommodityRepository OCommodityRepository)
                :base(OCommodityRepository)
        {
            _OCommodityRepository = OCommodityRepository;
        }
        public override async Task<string> CreateNameofContainer(OCommodity entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class SOCommodityBlobContainerFactory : EntityContainerFactory<SOCommodity>, ISOCommodityBlobContainerFactory
    {
        private readonly ISOCommodityRepository _SOCommodityRepository;
        public SOCommodityBlobContainerFactory(ISOCommodityRepository SOCommodityRepository)
                :base(SOCommodityRepository)
        {
            _SOCommodityRepository = SOCommodityRepository;
        }
        public override async Task<string> CreateNameofContainer(SOCommodity entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class MOCommodityBlobContainerFactory : EntityContainerFactory<MOCommodity>, IMOCommodityBlobContainerFactory
    {
        private readonly IMOCommodityRepository _MOCommodityRepository;
        public MOCommodityBlobContainerFactory(IMOCommodityRepository MOCommodityRepository)
                :base(MOCommodityRepository)
        {
            _MOCommodityRepository = MOCommodityRepository;
        }
        public override async Task<string> CreateNameofContainer(MOCommodity entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class EOCommodityBlobContainerFactory : EntityContainerFactory<EOCommodity>, IEOCommodityBlobContainerFactory
    {
        private readonly IEOCommodityRepository _EOCommodityRepository;
        public EOCommodityBlobContainerFactory(IEOCommodityRepository EOCommodityRepository)
                :base(EOCommodityRepository)
        {
            _EOCommodityRepository = EOCommodityRepository;
        }
        public override async Task<string> CreateNameofContainer(EOCommodity entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface IOCommodityBlobStorage : IEntityBlobStorage<OCommodity>
    {

    }
    public interface ISOCommodityBlobStorage : IEntityBlobStorage<SOCommodity>
    {

    }
    public interface IMOCommodityBlobStorage : IEntityBlobStorage<MOCommodity>
    {

    }
    public interface IEOCommodityBlobStorage : IEntityBlobStorage<EOCommodity>
    {

    }
    public interface IOrderCenterBlobStorage : IEntityBlobStorage<OrderCenter>
    {

    }
    public class OCommodityBlobStorage : EntityBlobStorage<OCommodity>, IOCommodityBlobStorage
    {
        public OCommodityBlobStorage(IOCommodityBlobContainerFactory OCommodityBlobContainerFactory)
            : base(OCommodityBlobContainerFactory)
        {

        }
    }
    public class SOCommodityBlobStorage : EntityBlobStorage<SOCommodity>, ISOCommodityBlobStorage
    {
        public SOCommodityBlobStorage(ISOCommodityBlobContainerFactory SOCommodityBlobContainerFactory)
            : base(SOCommodityBlobContainerFactory)
        {

        }

    }
    public class MOCommodityBlobStorage : EntityBlobStorage<MOCommodity>, IMOCommodityBlobStorage
    {
        public MOCommodityBlobStorage(IMOCommodityBlobContainerFactory MOCommodityBlobContainerFactory)
            : base(MOCommodityBlobContainerFactory)
        {

        }
    }
    public class EOCommodityBlobStorage : EntityBlobStorage<EOCommodity>, IEOCommodityBlobStorage
    {
        public EOCommodityBlobStorage(IEOCommodityBlobContainerFactory EOCommodityBlobContainerFactory)
            : base(EOCommodityBlobContainerFactory)
        {

        }
    }
    public class OrderCenterBlobStorage : EntityBlobStorage<OrderCenter>, IOrderCenterBlobStorage
    {
        public OrderCenterBlobStorage(IOrderCenterBlobContainerFactory OrderCenterBlobContainerFactory)
            : base(OrderCenterBlobContainerFactory)
        {

        }
    }
}