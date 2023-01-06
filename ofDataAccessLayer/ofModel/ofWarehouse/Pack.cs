using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.Model
{
    [BackUpDbContext(typeof(BackUpWarehouseDbContext), DbConnectionString.BackUpWarehouseDbConnection)]
    [DbContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [DataContext(typeof(WarehouseDataContext))]
    public class Pack : Entity
    {
        public string Material { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
    }
}
