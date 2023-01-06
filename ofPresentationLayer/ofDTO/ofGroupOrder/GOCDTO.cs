using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessData.ofPresentationLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using BusinessData.ofPresentationLayer.ofDTOContext;
using BusinessData.ofPresentationLayer.ofDTOServices.ofGroupOrder;

namespace BusinessData.ofPresentationLayer.ofDTO.ofGroupOrder
{
    [HttpDTOService(typeof(GOCDTOService))]
    [DTOContext(typeof(GroupOrderDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class GOCDTO : CenterDTO
    {
        [Query(QueryCode.String)]public string OrderCenters { get; set; }
        [Query(QueryCode.String)]public string WarehouseId { get; set; }
    }
    [HttpDTOService(typeof(GOCCDTOService))]
    [DTOContext(typeof(GroupOrderDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class GOCCDTO : CommodityDTO
    {

    }
    [HttpDTOService(typeof(SGOCDTOService))]
    [DTOContext(typeof(GroupOrderDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class SGOCDTO : SStatusDTO
    {

    }
    [HttpDTOService(typeof(MGOCDTOService))]
    [DTOContext(typeof(GroupOrderDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class MGOCDTO : MStatusDTO
    {

    }
    [HttpDTOService(typeof(EGOCDTOService))]
    [DTOContext(typeof(GroupOrderDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class EGOCDTO : EStatusDTO
    {

    }
}