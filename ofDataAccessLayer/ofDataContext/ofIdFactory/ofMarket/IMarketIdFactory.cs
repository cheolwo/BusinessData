using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;

namespace BusinessLogic.ofEntityManager.ofMarket.ofIdFactory
{
    public interface IMarketIdFactory : ICenterIdFactory<Market>
    {
        
    }
    public interface IMCommodityIdFactory : ICommodityIdFactory<MCommodity>
    {
        
    }
    public interface ISMCommodityIdFactory : IStatusIdFactory<SMCommodity>
    {
        
    }
    public interface IMMCommodityIdFactory : IStatusIdFactory<MMCommodity>
    {
        
    }
    public interface IEMCommodityIdFactory : IStatusIdFactory<EMCommodity>
    {
        
    }
    public interface IPlatMarketIdFactory : ICenterIdFactory<PlatMarket>
    {

    }
}