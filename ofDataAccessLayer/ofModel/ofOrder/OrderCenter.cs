using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofOrder.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofOrder.ofModel
{
    public static class ViewNameofOrderCenter
    {
        public const string OrderCenter = "OrderCenter";
        public const string OCommodity = "OCommodity";
        public const string SOCommodity = "SOCommodity";
        public const string MOCommodity = "MOCommodity";
        public const string EOCommodity = "EOCommodity";
        public const string OrderGroup = "OrderGroup";
    }
    [Relation(typeof(OrderCenter), "O")]
    [BackUpDbContext(typeof(BackUpOrderDbContext), DbConnectionString.BackUpOrderDbConnection)]
    [DbContext(typeof(OrderDbContext), DbConnectionString.OrderDbConnection)]
    [DataContext(typeof(OrderDataContext))]
    public class OrderCenter : Center
    {
        public List<OCommodity> OCommodities {get; set;}
        public List<SOCommodity> SOCommodities {get; set;}
        public List<MOCommodity> MOCommodities {get; set;}
        public List<EOCommodity> EOCommodities {get; set;}
        public OrderCenter()
        {
        }
    }
    /*
     * 상적주문 : 상적창고입고, 상적창고출고, 상적배송센터입고, 상적배송센터출고
     *           상적생산, 상적거래
     */
    /*
        // 만장일치가 나오지 않는 경우 재투표실시합니다.
    */
    public static class OrderUnit
    {
        public const string Kg = "Kg";
        public const string Quantity = "Quantity";
        public const string Box = "Box";
        public const string Gram = "Gram";
    }
    public enum OrderType { SW, EW, SD, ED, SP, ST }
    [BackUpDbContext(typeof(BackUpOrderDbContext), DbConnectionString.BackUpOrderDbConnection)]
    [DbContext(typeof(OrderDbContext), DbConnectionString.OrderDbConnection)]
    [DataContext(typeof(OrderDataContext))]
    [Relation(typeof(OrderGroup), "OG")]
    public class OrderGroup : Entity
    {
        public string GroupName {get; set;}
        public Dictionary<string, int> OrdreCenterKeyOrderQuantityValue {get; set;}
        [Get]public string PlatFormCommodityId {get; set;}
        [Get]public string ProductCenterId {get; set;}
        [Get]public int Price {get; set;}
        [Get]public string Unit {get; set;} 
        [Get]public string PCommodityId {get; set;}
        [Get]public string SPCommodityId {get; set;}
        [Get]public string MPCommodityId {get; set;}
        [Get]public string EPCommodityId {get; set;}
        [Get]public string WarehouseId {get; set;}
        [Get]public string DeliveryCenterId {get; set;}
        [Get]public string DCommodityId {get; set;}
        [Get]public string SDCommodityId {get; set;}
        [Get]public string MDCommodityId {get; set;}
        [Get]public string EDCommodityId {get; set;}
        [Get]public string WCommodityId {get; set;}
        [Get]public string SWCommodityId {get; set;}
        
        public OrderGroup()
        {
            OrdreCenterKeyOrderQuantityValue = new();
        }
    }
    public class OGCommodity : Commodity
    {
        public OGCommodity()
        {

        }
    }
}
