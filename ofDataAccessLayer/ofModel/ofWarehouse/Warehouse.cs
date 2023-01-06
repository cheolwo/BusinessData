using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofInterface;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext;
using Microsoft.AspNetCore.Authorization;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.Model
{
    public enum CenterOwnerType {Owner, Lessor}
    public interface IJounral
    {
        string GetJounral(string CenterOwnerType);
    }

    public class JounrnalAttribute : Attribute
    {
        public Type type {get; set;}
        public JounrnalAttribute(Type type)
        {
            this.type = type;
        }
    }

    [BackUpDbContext(typeof(BackUpWarehouseDbContext), DbConnectionString.BackUpWarehouseDbConnection)]
    [DbContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection)]
    [DataContext(typeof(WarehouseDataContext))]
    [Authorize(Roles ="Admin_Warehouse")]
    [Relation(typeof(Warehouse), "W")] 
    public class Warehouse : Center, IRelatedCenter
    {
        public List<WCommodity> WCommodities { get; set; }
        public List<EWCommodity> EWCommodities { get; set; }
        public List<MWCommodity> MWCommodities { get; set; }
        public List<SWCommodity> SWCommodities { get; set; }
        public List<LoadFrame> LoadFrames { get; set; }
        public List<DotBarcode> DotBarcodes {get; set;}
        public List<WorkingDesk> WorkingDesks {get; set;}
        public List<DividedTag> DividedTags {get; set;}
        public List<IncomingTag> IncomingTags {get; set;}
        public Warehouse()
        {
            WCommodities = new List<WCommodity>();
            EWCommodities = new();
            MWCommodities = new List<MWCommodity>();
            SWCommodities = new List<SWCommodity>();
            LoadFrames = new();
            DotBarcodes = new();
            WorkingDesks = new();
            DividedTags = new();
            IncomingTags = new();
        }
        public override Center GetRelatedCenter()
        {
            return this;
        }

        public string GetBarcodeInfo()
        {
            throw new NotImplementedException();
        }
    }

    // 버퍼처럼 쓰이는 곳, 승낙되면 삭제됨
    public class WaitAccepting
    {
        [Key] public int Id { get; set; }
        public bool IsAccecpt { get; set; }
        public string Message { get; set; }
        [Required] public string UserId { get; set; }    // 와부 거래입고 Id
        [Required] public WCommodity WCommodity { get; set; } // Json 형태로 저장
        [Required] public Warehouse Warehouse { get; set; }
    }

    // UserInfo 같은 게 있었으면 좋겠네. 거래가 이루어질 때 승낙자가 볼 수 있도록

    public enum Country { Korea = 1, China = 2, Japan = 3, Russia = 4, America = 5 }
}
