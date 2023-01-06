using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.Model
{
    [BackUpDbContext(typeof(BackUpWarehouseDbContext), DbConnectionString.BackUpWarehouseDbConnection)]
    [DbContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [DataContext(typeof(WarehouseDataContext))]
    [Relation(typeof(IncomingTag), "IT")]
    public class IncomingTag : Entity
    {
         public string SWCommodityId { get; set; }
         public string WareohuseId {get; set;}
        public Warehouse Warehouse { get; set; }
        public List<DividedTag> DividedTags { get; set; }

        public string GetBarcodeInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}
