using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofModel;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;

namespace BusinessLogic.ofEntityManager.ofDeliveryCenter.ofIdFactory
{
    public interface IDeliveryCenterIdFactory : ICenterIdFactory<DeliveryCenter>
    {
        
    }
    public interface IDCommodityIdFactory : ICommodityIdFactory<DCommodity>
    {
        
    }
    public interface ISDCommodityIdFactory : IStatusIdFactory<SDCommodity>
    {
        
    }
    public interface IMDCommodityIdFactory : IStatusIdFactory<MDCommodity>
    {
        
    }
    public interface IEDCommodityIdFactory : IStatusIdFactory<EDCommodity>
    {
        
    }
}