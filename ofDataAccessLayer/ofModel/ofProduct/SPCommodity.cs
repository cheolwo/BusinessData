using System.Collections.Generic;
using BusinessData.ofProduct.ofDbContext;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;

namespace BusinessData.ofDataAccessLayer.ofProduct.ofModel
{
    [BackUpDbContext(typeof(BackUpProductDbContext), DbConnectionString.BackUpProductDbConnection)]
    [DbContext(typeof(ProductDbContext), DbConnectionString.ProductDbConnection)]
    [DataContext(typeof(ProductDataContext))]
    [Relation(typeof(SPCommodity), "PLPS")]
    public class SPCommodity : SStatus
    {
        public string StartedTime { get; set; }
        public string AnticipatingEndedTime { get; set; }
        public string Unit { get; set; }
        public float AnticipatingQuantity { get; set; }
        public bool IsTablable { get; set; }
        public PCommodity PCommodity { get; set; }
        public ProductLand ProductLand { get; set; }
        public Producter Producter { get; set; }
        public ProductCenter ProductCenter { get; set; }
        public List<MPCommodity> MPCommodities { get; set; }
        public SPCommodity()
        {
            PCommodity = new();
        }
    }
}