using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using BusinessData.ofPresentationLayer.ofDTO.ofCommon;
using NMemory.Data;
using System.Collections.Generic;
using BusinessData.ofPresendationLayer.ofDTOServices.ofMarket;
using BusinessData.ofPresentationLayer.ofDTOContext;
using BusinessData.ofPresentationLayer.ofActorContext.ofBusiness;
using BusinessData.ofPresendationLayer.ofActorContext.ofCommon;
using BusinessData.ofPresentationLayer.ofCommon;

namespace BusinessData.ofPresentationLayer.ofDTO.ofMarket
{
    [HttpDTOService(typeof(MarketDTOService))]
    [DTOContext(typeof(MarketDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class MarketDTO : CenterDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string NameofMarket { get; set; }
        [Query(QueryCode.With)][Many(ViewNameofMarket.PlatMarket, typeof(List<PlatMarket>))]public string PlatMarkets { get; set; }
        [Query(QueryCode.With)][Many(ViewNameofMarket.MCommodity, typeof(List<MCommodity>))]public string MCommodities {get; set;}
        [Query(QueryCode.With)][Many(ViewNameofMarket.SMCommodity, typeof(List<SMCommodity>))]public string SMCommodities {get; set; }
        [Query(QueryCode.With)][Many(ViewNameofMarket.MMCommodity, typeof(List<MMCommodity>))]public string MMCommodities {get; set;}
        [Query(QueryCode.With)][Many(ViewNameofMarket.EMCommodity, typeof(List<EMCommodity>))]public string EMCommodities {get; set;}
    }
    [HttpDTOService(typeof(PlatMarketDTOService))]
    [DTOContext(typeof(MarketDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class PlatMarketDTO : CenterDTO
    {
        [Query(QueryCode.String)][View(ViewMode.Get)]public string NameofPlatForm {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)]public string VendorId { get; set; }
        [View(ViewMode.Get)]public string VendorPassword {get; set;}
        [View(ViewMode.Detail)]public Binary AccessKey { get; set; }
        [View(ViewMode.Detail)]public Binary SecreatKey { get; set; }
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofMarket.PMMCommodity, typeof(List<MMCommodity>))] public string MMCommodities {get; set;}
    }
    [HttpDTOService(typeof(MCommodityDTOService))]
    [DTOContext(typeof(MarketDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class MCommodityDTO : CommodityDTO
    {
        [Query(QueryCode.With)][One(ViewNameofMarket.Market, typeof(Market))]public string Market {get; set;}
        [Query(QueryCode.With)][Many(ViewNameofMarket.SMCommodity, typeof(List<SMCommodity>))]public string SMCommodities {get; set;}
        [Query(QueryCode.With)][Many(ViewNameofMarket.MMCommodity, typeof(List<MMCommodity>))]public string MMCommodities {get; set;}
        [Query(QueryCode.With)][Many(ViewNameofMarket.EMCommodity, typeof(List<EMCommodity>))]public string EMCommodities {get; set;}
    }
    [HttpDTOService(typeof(SMCommodityDTOService))]
    [DTOContext(typeof(MarketDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class SMCommodityDTO : SStatusDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string MCommodity {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofMarket.MMCommodity, typeof(List<MMCommodity>))]public string MMCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.Market, typeof(Market))]public string Market {get; set;}
        [Query(QueryCode.String)][View(ViewMode.Get)]public string SWCommodityId {get; set;}
    }
    [HttpDTOService(typeof(MMCommodityDTOService))]
    [DTOContext(typeof(MarketDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class MMCommodityDTO : MStatusDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.PlatMarket, typeof(PlatMarket))]public string PlatMarket {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.Market, typeof(Market))]public string Market {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string MCommodity {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][Many(ViewNameofMarket.EMCommodity, typeof(List<EMCommodity>))]public string EMCommodities {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.SMCommodity, typeof(SMCommodity))]public string SMCommodity {get; set;}
    }
    [HttpDTOService(typeof(EMCommodityDTOService))]
    [DTOContext(typeof(MarketDTOContext))]
    [BusinessContext(typeof(OrdererContext), typeof(ForwarderContext), typeof(LogisterContext), typeof(SellerContext), typeof(ProducterContext))]
    public class EMCommodityDTO : EStatusDTO
    {
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.MCommodity, typeof(MCommodity))]public string MCommodity {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.MMCommodity, typeof(MMCommodity))]public string MMCommodity {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.PlatMarket, typeof(PlatMarket))]public string PlatMarket {get; set;}
        [Query(QueryCode.With)][View(ViewMode.Detail)][One(ViewNameofMarket.Market, typeof(Market))]public string Market {get; set;}
    }
}