using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofInterface;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext;
using Microsoft.AspNetCore.Authorization;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.Model
{

    [BackUpDbContext(typeof(BackUpWarehouseDbContext), DbConnectionString.BackUpWarehouseDbConnection)]
    [DbContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [DataContext(typeof(WarehouseDataContext))]
    [Authorize(Roles ="Admin_Warehouse, Employee_Warehouse")]
    [Relation(typeof(Warehouse), "WW")] 
    public class WCommodity : Commodity, IRelatedCenter, IRelatedRoles
    {
        public string Type {get; set;}
        [NotMapped]public string PakcingBarcode {get; set;}
        public double? Width { get; set; }
        public double? height { get; set; }
        public double? length { get; set; }
        public int Quantity {get; set;}
        public string MCommodityId {get; set;}
        public string TCommodityId {get; set;}    
        public List<SWCommodity> SWCommodities {get; set;}  
        public List<EWCommodity> EWCommodities {get; set;}  
        public List<MWCommodity> MWCommodities {get; set;} 
        public Warehouse Warehouse { get; set; }
        
        public WCommodity()
        {
        }
        public override Center GetRelatedCenter()
        {
            return Warehouse;
        }
        
        public string GetBarcodeInfo()
        {
            throw new NotImplementedException();
        }
    }

    [DataContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [Authorize(Roles ="Admin_Warehouse, Employee_Warehouse")]
    [Relation(typeof(Warehouse), "WWS")] 
    public class SWCommodity : SStatus, IRelatedCenter, IRelatedRoles
    {
        public int IncomingQuantity { get; set; }
        public string IncomingTagId {get; set;}
        public List<MWCommodity> MWCommodities {get; set;}
        public WCommodity WCommodity {get; set;}
        public Warehouse Warehouse {get; set;}

        public SWCommodity()
        {
        }
        public override Center GetRelatedCenter()
        {
            return Warehouse;
        }

        public string GetBarcodeInfo()
        {
            throw new NotImplementedException();
        }
    }

    [DataContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [Authorize(Roles ="Admin_Warehouse, Employee_Warehouse")]
    [Relation(typeof(Warehouse), "WWM")] 
    public class MWCommodity : MStatus, IRelatedCenter, IRelatedRoles
    {
        public List<EWCommodity> EWCommodities {get; set;}
        public LoadFrame LoadFrame {get; set;}
        public Warehouse Warehouse {get; set;}
        public SWCommodity SWCommodity { get; set; }
        public WCommodity WCommodity { get; set; }
        public MWCommodity()
        {
        }
        public override Center GetRelatedCenter()
        {
            return Warehouse;
        }

        public string GetBarcodeInfo()
        {
            throw new NotImplementedException();
        }
    }

    [DataContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [Authorize(Roles ="Admin_Warehouse, Employee_Warehouse")]
    [Relation(typeof(Warehouse), "WWE")] 
    public class EWCommodity : EStatus, IRelatedCenter, IRelatedRoles
    {
        public int OutgoingQuantity {get; set;} // 출고수량
        public WCommodity WCommodity {get; set;}
        public Warehouse Warehouse {get; set;}
        public MWCommodity  MWCommodity { get; set; }

        public EWCommodity()
        {
        }
        public override Center GetRelatedCenter()
        {
            return Warehouse;
        }

        public string GetBarcodeInfo()
        {
            throw new NotImplementedException();
        }
    }

    public enum StateofWCommodity
    {
        WIncoming = 1, Incoming = 2, WInspecting = 3,
        Inspecting, WLoading, Loading, WPicking,
        Picking, WPacking, Packing, WOutgoing, Outgoing
    }
}
