using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofOrder.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofOrder.ofModel
{
    [Relation(typeof(MOCommodity), nameof(MOCommodity))]
    [BackUpDbContext(typeof(BackUpOrderDbContext), DbConnectionString.BackUpOrderDbConnection)]
    [DbContext(typeof(OrderDbContext), DbConnectionString.OrderDbConnection)]
    [DataContext(typeof(OrderDataContext))]
    public class MOCommodity : MStatus
    {
        public OCommodity OCommodity {get; set;}
        public OrderCenter OrderCenter {get; set; }
        public SOCommodity SOCommodity { get; set; }
        public List<EOCommodity> EOCommodities { get; set; }
    }
}
