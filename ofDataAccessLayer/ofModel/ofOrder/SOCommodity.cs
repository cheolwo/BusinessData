using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofOrder.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofOrder.ofModel
{
    [Relation(typeof(SOCommodity), nameof(SOCommodity))]
    [BackUpDbContext(typeof(BackUpOrderDbContext), DbConnectionString.BackUpOrderDbConnection)]
    [DbContext(typeof(OrderDbContext), DbConnectionString.OrderDbConnection)]
    [DataContext(typeof(OrderDataContext))]
    public class SOCommodity : SStatus
    {
        public string Price { get; set; }
        public string QualityTerms { get; set; }
        public string Incorterms { get; set; }
        public OCommodity OCommodity {get; set;}
        public OrderCenter OrderCenter {get; set;}
        public List<MOCommodity> MOCommodities {get; set;}
    }
}
