using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofTrade.ofDbContext;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;

namespace BusinessData.ofDataAccessLayer.ofTrade.ofModel
{
    [BackUpDbContext(typeof(BackUpTradeDbContext), DbConnectionString.BackUpTradeDbConnection)]
    [DbContext(typeof(TradeDbContext), DbConnectionString.TradeDbConnection)]
    [DataContext(typeof(TradeDataContext))]
    [Relation(typeof(TradeCenter), nameof(TradeCenter))] 
    public class TradeCenter : Center
    {
        public List<TCommodity> TCommodities {get; set;}
        public TradeCenter()
        {
            TCommodities = new();
        }
    }
    [BackUpDbContext(typeof(BackUpTradeDbContext), DbConnectionString.BackUpTradeDbConnection)]
    [DbContext(typeof(TradeDbContext), DbConnectionString.TradeDbConnection)]
    [DataContext(typeof(TradeDataContext))]
    [Relation(typeof(TCommodity), nameof(TCommodity))] 
    public class TCommodity : Commodity
    {
        public string PCommodityId {get; set;}
        public List<STCommodity> STCommodities {get; set;}
        public List<MTCommodity> MTCommodities {get; set;}
        public List<ETCommodity> ETCommodities {get; set;}
        public TradeCenter TradeCenter {get; set;}

        public TCommodity()
        {
            SetRelation(typeof(TCommodity), "TT");
            STCommodities = new();
            MTCommodities = new();
            ETCommodities = new();
            TradeCenter = new();
        }
    }
    [BackUpDbContext(typeof(BackUpTradeDbContext), DbConnectionString.BackUpTradeDbConnection)]
    [DbContext(typeof(TradeDbContext), DbConnectionString.TradeDbConnection)]
    [DataContext(typeof(TradeDataContext))]
    [Relation(typeof(STCommodity), nameof(STCommodity))] 
    public class STCommodity : SStatus
    {
        public string BuyerId {get; set;} 
        public string Message {get; set;}
        public float Payed {get; set;}
        public bool IsAccept {get; set;}
        public string MTCommodityId {get; set;}
        public TCommodity TCommoditiy {get; set;}

        public STCommodity()
        {
            SetRelation(typeof(STCommodity), "TTS");
            TCommoditiy = new();
        }
    }
    [BackUpDbContext(typeof(BackUpTradeDbContext), DbConnectionString.BackUpTradeDbConnection)]
    [DbContext(typeof(TradeDbContext), DbConnectionString.TradeDbConnection)]
    [DataContext(typeof(TradeDataContext))]
    [Relation(typeof(MTCommodity), nameof(MTCommodity))] 
    public class MTCommodity  : MStatus
    {
        public bool IsAccecptBillofLading {get; set;}
        public bool IsAcceptCerticificateofOrigin {get; set;}
        public bool IsAcceptCredit {get; set;}
        public string ETCommodityId {get; set;}
        public TCommodity TCommodity {get; set;}
        public MTCommodity()
        {
            SetRelation(typeof(MTCommodity), "TTM");
            TCommodity = new();
        }
    }
    [BackUpDbContext(typeof(BackUpTradeDbContext), DbConnectionString.BackUpTradeDbConnection)]
    [DbContext(typeof(TradeDbContext), DbConnectionString.TradeDbConnection)]
    [DataContext(typeof(TradeDataContext))]
    [Relation(typeof(ETCommodity), nameof(ETCommodity))] 
    public class ETCommodity  : EStatus
    {
        public string MTCommodityId {get; set;}
        public string SWCommodityId {get; set;}
        public TCommodity TCommodity { get; set; }
        public ETCommodity()
        {
            SetRelation(typeof(ETCommodity), "TTE");
            TCommodity = new();
        }
    }
    public enum TransactionType { Trade = 0, Contract = 1 }
}
