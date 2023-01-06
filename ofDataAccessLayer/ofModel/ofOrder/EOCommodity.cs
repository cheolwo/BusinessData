using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofOrder.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofOrder.ofModel
{
    [Relation(typeof(EOCommodity), nameof(EOCommodity))]
    [BackUpDbContext(typeof(BackUpOrderDbContext), DbConnectionString.BackUpOrderDbConnection)]
    [DbContext(typeof(OrderDbContext), DbConnectionString.OrderDbConnection)]
    [DataContext(typeof(OrderDataContext))]
    public class EOCommodity : EStatus
    {
        public int OutgoingQuantity { get; set; } // 출고수량
        public MOCommodity MOCommodity { get; set; }
        public OCommodity OCommodity { get; set; }
        public OrderCenter OrderCenter { get; set; }
    }
}
