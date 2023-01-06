using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.Model
{
    [BackUpDbContext(typeof(BackUpWarehouseDbContext), DbConnectionString.BackUpWarehouseDbConnection)]
    [DbContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [DataContext(typeof(WarehouseDataContext))]
    [Relation(typeof(DividedTag), "DT")]
    public class DividedTag : Entity
    {
        public bool Attached { get; set; }
        public string IncomingTagId {get; set;}
        public string WarehouseId {get; set;}
        public IncomingTag IncomingTag { get; set; }
        public Warehouse Warehouse { get; set; }
        public DividedTag()
        {
            Warehouse = new();
            IncomingTag = new();
        }
        public string GetBarcodeInfo()
        {
            throw new System.NotImplementedException();
        }
    }
}
