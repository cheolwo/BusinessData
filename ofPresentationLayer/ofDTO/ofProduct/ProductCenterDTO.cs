using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using System;
using System.Collections.Generic;
using BusinessData.ofPresendationLayer.ofDTOServices.ofProduct;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using BusinessData.ofPresentationLayer.ofDTOContext;
using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofProduct
{
    [HttpDTOService(typeof(EPCommodityDTOService))]
    [DTOContext(typeof(ProductDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class EPCommodityDTO : EStatusDTO
    {
        [Query(QueryCode.With)][One(typeof(PCommodity))] public string PCommodity { get; set; }
        [Query(QueryCode.With)][One(typeof(ProductLand))] public string ProductLand {get; set;}
        [Query(QueryCode.With)][One(typeof(Producter))] public string Producter { get; set;}
        [Query(QueryCode.With)][One(typeof(MPCommodity))] public string MPCommodity {get; set;}
    }
    [HttpDTOService(typeof(MPCommodityDTOService))]
    [DTOContext(typeof(ProductDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class MPCommodityDTO : MStatusDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(PCommodity))] public string PCommodity { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(ProductLand))] public string ProductLand {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(Producter))] public string Producter { get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(SPCommodity))] public string SPCommodity {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<EPCommodity>))] public string EPCommodities {get; set;}
    }
    [HttpDTOService(typeof(PCommodityDTOService))]
    [DTOContext(typeof(ProductDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class PCommodityDTO : CommodityDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Detail)]public string Category {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Detail)] public string Brand {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<SPCommodity>))] public string SPCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<MPCommodity>))] public string MPCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<EPCommodity>))] public string EPCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(ProductLand))] public string ProductLand {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(Producter))]public string Producter {get; set;} 
    }
    [HttpDTOService(typeof(ProductCenterDTOService))]
    [DTOContext(typeof(ProductDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class ProductCenterDTO : CenterDTO
    {
        public string Producters {get; set;}
        [Query(QueryCode.String)]public string CoprNumber {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<ProductLand>))] public string ProductLands {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<PCommodity>))] public string PCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<SPCommodity>))] public string SPCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<MPCommodity>))] public string MPCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<EPCommodity>))] public string EPCommodities {get; set;}
    }
    [HttpDTOService(typeof(ProducterDTOService))]
    [DTOContext(typeof(ProductDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class ProducterDTO : CenterDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<ProductCenter>))]public string ProductCenters { get; set; } 
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<PCommodity>))]public string PCommodities { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<SPCommodity>))]public string SPCommodities{ get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<MPCommodity>))]public string MPCommodities { get; set; }    
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<EPCommodity>))]public string EPCommodities { get; set;}
    }
    [HttpDTOService(typeof(ProductLandDTOService))]
    [DTOContext(typeof(ProductDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class ProductLandDTO : EntityDTO
    {
        [Query(QueryCode.Time)][View(ViewMode.Get)]public DateTime StartedTime {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)]public string AnticipatingEndedTime {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)]public string Unit {get; set;}
        [Query(QueryCode.Int)][View(ViewMode.Get)]public float AnticipatingQuantity {get; set;}
        public bool IsTablable {get; set;}
        [View(ViewMode.Get)]public string OrderGroups {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(PCommodity))] public string PCommodity { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(ProductLand))] public string ProductLand {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(Producter))] public string Producter { get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(ProductCenter))]public string ProductCenter {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<MPCommodity>))] public string MPCommodities {get; set;}
    }
    [HttpDTOService(typeof(SPCommodityDTOService))]
    [DTOContext(typeof(ProductDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class SPCommodityDTO : SStatusDTO
    {
        [Query(QueryCode.Time)][View(ViewMode.Get)]public DateTime StartedTime {get; set;}
        [Query(QueryCode.Time)][View(ViewMode.Get)]public DateTime AnticipatingEndedTime {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)]public string Unit {get; set;}
        [Query(QueryCode.Int)][View(ViewMode.Get)]public float AnticipatingQuantity {get; set;}
        [View(ViewMode.Get)]public string OrderGroups {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(PCommodity))] public string PCommodity { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(ProductLand))] public string ProductLand {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(Producter))] public string Producter { get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(typeof(ProductCenter))]public string ProductCenter {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(typeof(List<MPCommodity>))] public string MPCommodities {get; set;}
    }
    
}