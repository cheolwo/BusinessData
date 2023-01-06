using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofOrder.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofOrder.ofModel
{
    [Relation(typeof(OCommodity), "OO")]
    [BackUpDbContext(typeof(BackUpOrderDbContext), DbConnectionString.BackUpOrderDbConnection)]
    [DbContext(typeof(OrderDbContext), DbConnectionString.OrderDbConnection)]
    [DataContext(typeof(OrderDataContext))]
    public class OCommodity : Commodity
    {
        [Get] public string OrderId { get; set; } // 이거의 존재는 Order Table 이라는 테이블의 존재를 의미하는데..
        public string OrderType { get; set; }
        [Detail][Many(ViewNameofOrderCenter.SOCommodity)]public List<SOCommodity> SOCommodities {get; set;}
        [Detail][Many(ViewNameofOrderCenter.MOCommodity)]public List<MOCommodity> MOCommodities {get; set;}
        [Detail][Many(ViewNameofOrderCenter.EOCommodity)]public List<EOCommodity> EOCommodities {get; set;}
        [Detail]public OrderCenter OrderCenter {get; set;}
    }
}
