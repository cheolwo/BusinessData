using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofProduct;
using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofEntityManager.ofProduct.ofBlobStorage
{
    public interface IPCommodityBlobContainerFactory : IEntityContainerFactory<PCommodity>
    {

    }
    public interface ISPCommodityBlobContainerFactory : IEntityContainerFactory<SPCommodity>
    {

    }
    public interface IMPCommodityBlobContainerFactory : IEntityContainerFactory<MPCommodity>
    {

    }
    public interface IEPCommodityBlobContainerFactory : IEntityContainerFactory<EPCommodity>
    {

    }
    public interface IProductCenterBlobContainerFactory : IEntityContainerFactory<ProductCenter>
    {

    }
    public class ProductCenterBlobContainerFactory : EntityContainerFactory<ProductCenter>, IProductCenterBlobContainerFactory
    {
        private readonly IProductCenterRepository _ProductCenterRepository;
        public ProductCenterBlobContainerFactory(IProductCenterRepository ProductCenterRepository)
                :base(ProductCenterRepository)
        {
            _ProductCenterRepository = ProductCenterRepository;
        }
        public override async Task<string> CreateNameofContainer(ProductCenter entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class PCommodityBlobContainerFactory : EntityContainerFactory<PCommodity>, IPCommodityBlobContainerFactory
    {
        private readonly IPCommodityRepository _PCommodityRepository;
        public PCommodityBlobContainerFactory(IPCommodityRepository PCommodityRepository)
                :base(PCommodityRepository)
        {
            _PCommodityRepository = PCommodityRepository;
        }
        public override async Task<string> CreateNameofContainer(PCommodity entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class SPCommodityBlobContainerFactory : EntityContainerFactory<SPCommodity>, ISPCommodityBlobContainerFactory
    {
        private readonly ISPCommodityRepository _SPCommodityRepository;
        public SPCommodityBlobContainerFactory(ISPCommodityRepository SPCommodityRepository)
                :base(SPCommodityRepository)
        {
            _SPCommodityRepository = SPCommodityRepository;
        }
        public override async Task<string> CreateNameofContainer(SPCommodity entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class MPCommodityBlobContainerFactory : EntityContainerFactory<MPCommodity>, IMPCommodityBlobContainerFactory
    {
        private readonly IMPCommodityRepository _MPCommodityRepository;
        public MPCommodityBlobContainerFactory(IMPCommodityRepository MPCommodityRepository)
                :base(MPCommodityRepository)
        {
            _MPCommodityRepository = MPCommodityRepository;
        }
        public override async Task<string> CreateNameofContainer(MPCommodity entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public class EPCommodityBlobContainerFactory : EntityContainerFactory<EPCommodity>, IEPCommodityBlobContainerFactory
    {
        private readonly IEPCommodityRepository _EPCommodityRepository;
        public EPCommodityBlobContainerFactory(IEPCommodityRepository EPCommodityRepository)
                :base(EPCommodityRepository)
        {
            _EPCommodityRepository = EPCommodityRepository;
        }
        public override async Task<string> CreateNameofContainer(EPCommodity entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface IPCommodityBlobStorage : IEntityBlobStorage<PCommodity>
    {

    }
    public interface ISPCommodityBlobStorage : IEntityBlobStorage<SPCommodity>
    {

    }
    public interface IMPCommodityBlobStorage : IEntityBlobStorage<MPCommodity>
    {

    }
    public interface IEPCommodityBlobStorage : IEntityBlobStorage<EPCommodity>
    {

    }
    public interface IProductCenterBlobStorage : IEntityBlobStorage<ProductCenter>
    {

    }
    public class PCommodityBlobStorage : EntityBlobStorage<PCommodity>, IPCommodityBlobStorage
    {
        public PCommodityBlobStorage(IPCommodityBlobContainerFactory PCommodityBlobContainerFactory)
            : base(PCommodityBlobContainerFactory)
        {

        }
    }
    public class SPCommodityBlobStorage : EntityBlobStorage<SPCommodity>, ISPCommodityBlobStorage
    {
        public SPCommodityBlobStorage(ISPCommodityBlobContainerFactory SPCommodityBlobContainerFactory)
            : base(SPCommodityBlobContainerFactory)
        {

        }

    }
    public class MPCommodityBlobStorage : EntityBlobStorage<MPCommodity>, IMPCommodityBlobStorage
    {
        public MPCommodityBlobStorage(IMPCommodityBlobContainerFactory MPCommodityBlobContainerFactory)
            : base(MPCommodityBlobContainerFactory)
        {

        }
    }
    public class EPCommodityBlobStorage : EntityBlobStorage<EPCommodity>, IEPCommodityBlobStorage
    {
        public EPCommodityBlobStorage(IEPCommodityBlobContainerFactory EPCommodityBlobContainerFactory)
            : base(EPCommodityBlobContainerFactory)
        {

        }
    }
    public class ProductCenterBlobStorage : EntityBlobStorage<ProductCenter>, IProductCenterBlobStorage
    {
        public ProductCenterBlobStorage(IProductCenterBlobContainerFactory ProductCenterBlobContainerFactory)
            : base(ProductCenterBlobContainerFactory)
        {

        }
    }
}