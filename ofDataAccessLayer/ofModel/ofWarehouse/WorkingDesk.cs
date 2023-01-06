using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.Model
{
    [BackUpDbContext(typeof(BackUpWarehouseDbContext), DbConnectionString.BackUpWarehouseDbConnection)]
    [DbContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [DataContext(typeof(WarehouseDataContext))]
    [Relation(typeof(WorkingDesk), "WD")]
    public class WorkingDesk : Entity
    {
        public WorkingDesk()
        {
            Warehouse = new();
        }

        public bool IsUsed {get; set;}
        public Warehouse Warehouse {get; set;}
    }
    [BackUpDbContext(typeof(BackUpWarehouseDbContext), DbConnectionString.BackUpWarehouseDbConnection)]
    [DbContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [DataContext(typeof(WarehouseDataContext))]
    public class DotBarcode : Entity
    {
        public DotBarcode()
        {
        }
    }
}