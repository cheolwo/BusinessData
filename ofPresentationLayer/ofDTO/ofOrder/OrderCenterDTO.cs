using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using System.Collections.Generic;
using BusinessData.ofPresendationLayer.ofDTOServices.ofOrder;
using BusinessData.ofPresentationLayer.ofDTOContext;
using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofOrder
{
    [HttpDTOService(typeof(EOCommodityDTOService))]
    [DTOContext(typeof(OrderDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class EOCommodityDTO : EStatusDTO
    {
        [Query(QueryCode.Int)][View(ViewMode.Get)]public string Price { get; set; }
        [Query(QueryCode.String)][View(ViewMode.Get)]public string QualityTerms { get; set; }
        [Query(QueryCode.String)][View(ViewMode.Get)]public string Incorterms { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OCommodity))] public string OCommodity { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OrderCenter))]public string OrderCenter { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.MOCommodity,typeof(List<MOCommodity>))] public string MOCommodities { get; set; }
    }
    [HttpDTOService(typeof(MOCommodityDTOService))]
    [DTOContext(typeof(OrderDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class MOCommodityDTO : MStatusDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OCommodity))] public string OCommodity { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OrderCenter))] public string OrderCenter { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(SOCommodity))] public string SOCommodity { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<EOCommodity>))]public string EOCommodities { get; set; }
    }
    [HttpDTOService(typeof(SOCommodityDTOService))]
    [DTOContext(typeof(OrderDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class SOCommodityDTO : SStatusDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string Price { get; set; }
        [Query(QueryCode.String)][View(ViewMode.Get)]public string QualityTerms { get; set; }
        [Query(QueryCode.String)][View(ViewMode.Get)]public string Incorterms { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OCommodity))] public string OCommodity { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OrderCenter))]public string OrderCenter { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.MOCommodity,typeof(List<MOCommodity>))] public string MOCommodities { get; set; }
    }
    [HttpDTOService(typeof(OCommodityDTOService))]
    [DTOContext(typeof(OrderDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class OCommodityDTO : CommodityDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string OrderType { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.SOCommodity, typeof(List<SOCommodity>))] public string SOCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.MOCommodity, typeof(List<MOCommodity>))] public string MOCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.EOCommodity, typeof(List<EOCommodity>))] public string EOCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(OrderCenter))] public string OrderCenter { get; set; }
    }
    [HttpDTOService(typeof(OrderCenterDTOService))]
    [DTOContext(typeof(OrderDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class OrderCenterDTO : CenterDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.OCommodity, typeof(List<OCommodity>))] public string OCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.SOCommodity, typeof(List<SOCommodity>))] public string SOCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.MOCommodity, typeof(List<MOCommodity>))] public string MOCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofOrderCenter.EOCommodity, typeof(List<EOCommodity>))] public string EOCommodities { get; set; }
    }
}