using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel
{
    // DataContext,
    // DbContext
    // BakcUpDbContext
    [Relation(typeof(GOC), nameof(GOC))]
    [BackUpDbContext(typeof(BackUpGroupOrderDbContext), DbConnectionString.BackUpGroupOrderDbConnection)]
    [DbContext(typeof(GroupOrderDbContext), DbConnectionString.GroupOrderDbConnection)]
    [DataContext(typeof(GroupOrderDataContext))]
    public class GOC : Center
    {
        public List<string> OrderCenters { get; set; }
        public string WarehouseId { get; set; }
    }
    [Relation(typeof(GOCC), nameof(GOCC))]
    [BackUpDbContext(typeof(BackUpGroupOrderDbContext), DbConnectionString.BackUpGroupOrderDbConnection)]
    [DbContext(typeof(GroupOrderDbContext), DbConnectionString.GroupOrderDbConnection)]
    [DataContext(typeof(GroupOrderDataContext))]
    public class GOCC : Commodity
    {
    }
    [Relation(typeof(SGOC), nameof(SGOC))]
    [BackUpDbContext(typeof(BackUpGroupOrderDbContext), DbConnectionString.BackUpGroupOrderDbConnection)]
    [DbContext(typeof(GroupOrderDbContext), DbConnectionString.GroupOrderDbConnection)]
    [DataContext(typeof(GroupOrderDataContext))]
    public class SGOC : SStatus
    {
        
    }
    [Relation(typeof(MGOC), nameof(MGOC))]
    [BackUpDbContext(typeof(BackUpGroupOrderDbContext), DbConnectionString.BackUpGroupOrderDbConnection)]
    [DbContext(typeof(GroupOrderDbContext), DbConnectionString.GroupOrderDbConnection)]
    [DataContext(typeof(GroupOrderDataContext))]
    public class MGOC : MStatus
    {
       
    }
    [Relation(typeof(EGOC), nameof(EGOC))]
    [BackUpDbContext(typeof(BackUpGroupOrderDbContext), DbConnectionString.BackUpGroupOrderDbConnection)]
    [DbContext(typeof(GroupOrderDbContext), DbConnectionString.GroupOrderDbConnection)]
    [DataContext(typeof(GroupOrderDataContext))]
    public class EGOC : EStatus
    {
       
    }
}