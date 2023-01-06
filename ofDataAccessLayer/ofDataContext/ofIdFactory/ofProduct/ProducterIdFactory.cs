using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofProduct.ofRepository;

namespace BusinessLogic.ofEntityManager.ofProduct.ofIdFactory
{
    public interface IProductCenterIdFactory : ICenterIdFactory<ProductCenter>
    {
        
    }
    public class ProductCenterIdFactory : CenterIdFactory<ProductCenter>, IProductCenterIdFactory
    {
        public ProductCenterIdFactory(IProductCenterRepository ProductCenterRepository)
            : base(ProductCenterRepository)
        {

        }
    }
    public interface IPCommodityIdFactory : ICommodityIdFactory<PCommodity>
    {
        
    }
    public class PCommodityIdFactory : CommodityIdFactory<PCommodity>, IPCommodityIdFactory
    {
        public PCommodityIdFactory(IPCommodityRepository PCommodityRepository)
            : base(PCommodityRepository)
        {

        }
    }
    public interface ISPCommodityIdFactory : IStatusIdFactory<SPCommodity>
    {
        
    }
    public class SPCommodityIdFactory : StatusIdFactory<SPCommodity>, ISPCommodityIdFactory
    {
        public SPCommodityIdFactory(ISPCommodityRepository SPCommodityRepository)
            : base(SPCommodityRepository)
        {

        }
    }
    public interface IMPCommodityIdFactory : IStatusIdFactory<MPCommodity>
    {
        
    }
    public class MPCommodityIdFactory : StatusIdFactory<MPCommodity>, IMPCommodityIdFactory
    {
        public MPCommodityIdFactory(IMPCommodityRepository MPCommodityRepository)
            : base(MPCommodityRepository)
        {

        }
    }
    public interface IEPCommodityIdFactory : IStatusIdFactory<EPCommodity>
    {
        
    }
    public class EPCommodityIdFactory : StatusIdFactory<EPCommodity>, IEPCommodityIdFactory
    {
        public EPCommodityIdFactory(IEPCommodityRepository EPCommodityRepository)
            : base(EPCommodityRepository)
        {

        }
    }
}