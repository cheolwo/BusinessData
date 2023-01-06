using System.Collections.Generic;
using BusinessData.ofProduct.ofDbContext;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofInterface;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;

namespace BusinessData.ofDataAccessLayer.ofProduct.ofModel
{
    [BackUpDbContext(typeof(BackUpProductDbContext), DbConnectionString.BackUpProductDbConnection)]
    [DbContext(typeof(ProductDbContext), DbConnectionString.ProductDbConnection)]
    [DataContext(typeof(ProductDataContext))]
    [Relation(typeof(ProductCenter), "PL")]
    public class ProductLand : Entity, IRelatedRoles
    {
        public ProductLand()
        {
            Producter = new();
        }
        public string LandCode { get; set; }
        public string Address { get; set; }
        public string AreaofProductLand { get; set; }
        public string AreaofRestProductLand { get; set; }
        public string PlantationType { get; set; }
        public string AreaofPlantation { get; set; }
        public string LandBookCode { get; set; }
        public Producter Producter { get; set; }
        public List<SPCommodity> SPCommodities { get; set; }
        public List<MPCommodity> MPCommodities { get; set; }
        public List<EPCommodity> EPCommodities { get; set; }
        public List<PCommodity> PCommodities { get; set; }
    }
}