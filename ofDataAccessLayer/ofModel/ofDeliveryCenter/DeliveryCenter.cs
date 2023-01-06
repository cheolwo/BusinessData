using System;
using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofInterface;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofDbContext;
using Microsoft.AspNetCore.Authorization;

namespace BusinessData.ofDataAccessLayer.ofDeliveryCenter.ofModel
{
    public static class ViewNameofDeliveryCenter
    {
        public const string DeliveryCenter = "배송센터";
        public const string DCommodity = "배송상품";
        public const string SDCommodity = "입고상품";
        public const string MDCommodity = "적재상품";
        public const string EDCommodity = "출고상품";
        public const string LoadFrame = "적재대";  
        public const string IncomingTag = "입고태그";
        public const string DividedTag = "분할태그";
        public const string DotBarcode ="도트태그";
    }
    [DataContext(typeof(DeliveryDbContext), DbConnectionString.DeliveryDbConnection, typeof(DeliveryDataContext))]
    [Authorize(Roles = "Admin_DeliverCenter")]
    [Relation(typeof(DeliveryCenter), "D")]
    public class DeliveryCenter : Center, IRelatedCenter, IRelatedRoles
    {
        [Detail][Many(ViewNameofDeliveryCenter.DCommodity)] public List<DCommodity> DCommodities {get; set;}
        [Detail][Many(ViewNameofDeliveryCenter.EDCommodity)] public List<EDCommodity> EDCommodities { get; set; }
        [Detail][Many(ViewNameofDeliveryCenter.MDCommodity)] public List<MDCommodity> MDCommodities { get; set; }
        [Detail][Many(ViewNameofDeliveryCenter.SDCommodity)] public List<SDCommodity> SDCommodities { get; set; }
        public DeliveryCenter()        
        {
            DCommodities = new();
            EDCommodities = new();
            MDCommodities = new();
            SDCommodities = new();
        }

        public override bool Equals(object obj)
        {
            return obj is DeliveryCenter center &&
                   Id == center.Id &&
                   CreateTime == center.CreateTime &&
                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, center.ImageofInfos) &&
                   Name == center.Name &&
                   UserId == center.UserId &&
                   Address == center.Address &&
                   EqualityComparer<List<DCommodity>>.Default.Equals(DCommodities, center.DCommodities);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override Center GetRelatedCenter()
        {
            return this;
        }
    }
    [DataContext(typeof(DeliveryDbContext), DbConnectionString.DeliveryDbConnection, typeof(DeliveryDataContext))]
    [Authorize(Roles ="Admin_DeliveryCenter, Employee_DeliveryCenter")]
    [Relation(typeof(DCommodity), "DD")]
    public class DCommodity : Commodity, IRelatedCenter, IRelatedRoles
    {
        public string WCommodityId {get; set;}
        public string MCommodityId {get; set;}
        public string DeliveryCenterId {get; set;}
        [Detail][One(ViewNameofDeliveryCenter.DeliveryCenter)]public DeliveryCenter DeliveryCenter {get; set;}
        [Detail][Many(ViewNameofDeliveryCenter.EDCommodity)] public List<EDCommodity> EDCommodities { get; set; }
        [Detail][Many(ViewNameofDeliveryCenter.MDCommodity)] public List<MDCommodity> MDCommodities { get; set; }
        [Detail][Many(ViewNameofDeliveryCenter.SDCommodity)] public List<SDCommodity> SDCommodities { get; set; }
        public DCommodity()
        {
            DeliveryCenter = new();
        }
        
        public override bool Equals(object obj)
        {
            return obj is DCommodity commodity &&
                   Id == commodity.Id &&
                   CreateTime == commodity.CreateTime &&
                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, commodity.ImageofInfos) &&
                   Name == commodity.Name &&
                   EqualityComparer<DeliveryCenter>.Default.Equals(DeliveryCenter, commodity.DeliveryCenter);
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }

    [DataContext(typeof(DeliveryDbContext), DbConnectionString.DeliveryDbConnection, typeof(DeliveryDataContext))]
    [Authorize(Roles ="Admin_DeliveryCenter, Employee_DeliveryCenter")]
    [Relation(typeof(SDCommodity), "DDS")]
    public class SDCommodity : SStatus, IRelatedCenter, IRelatedRoles
    {
        [Detail]public bool IsRightArrived {get; set;}
        [Detail]public string EWCommodityId {get; set;}
        [Detail][One(ViewNameofDeliveryCenter.DCommodity)]public DCommodity DCommodity {get; set;}
        [Detail][One(ViewNameofDeliveryCenter.DeliveryCenter)]public DeliveryCenter DeliveryCenter { get; set; }
        [Detail][Many]public List<MDCommodity> MDCommodities {get; set;}
        
        public SDCommodity()
        {
            DeliveryCenter = new();
        }

        public override bool Equals(object obj)
        {
            return obj is SDCommodity commodity &&
                   Id == commodity.Id &&
                   CreateTime == commodity.CreateTime &&
                   EqualityComparer<IList<ImageofInfo>>.Default.Equals(ImageofInfos, commodity.ImageofInfos) &&
                   IsRightArrived == commodity.IsRightArrived;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
    [DataContext(typeof(DeliveryDbContext), DbConnectionString.DeliveryDbConnection, typeof(DeliveryDataContext))]
    [Authorize(Roles ="Admin_DeliveryCenter, Employee_DeliveryCenter")]
    [Relation(typeof(MDCommodity), "DDM")] 
    public class MDCommodity : MStatus, IRelatedRoles
    {
        [One(ViewNameofDeliveryCenter.SDCommodity)]public SDCommodity SDCommodity {get; set;}
        [One(ViewNameofDeliveryCenter.SDCommodity)]public DCommodity DCommodity {get; set;}
        [One(ViewNameofDeliveryCenter.SDCommodity)]public DeliveryCenter DeliveryCenter { get; set; }
        [Many(ViewNameofDeliveryCenter.EDCommodity)]public List<EDCommodity> EDCommodities {get; set;}
        [Detail]public string SDCommodityId {get; set;}
        [Detail]public string DCommodityId {get; set;}
        [Detail]public string DeliveryCenterId {get; set;}
        public MDCommodity()
        {
            DeliveryCenter = new();
        }
    }
    [DataContext(typeof(DeliveryDbContext), DbConnectionString.DeliveryDbConnection, typeof(DeliveryDataContext))]
    [Authorize(Roles ="Admin_DeliveryCenter, Employee_DeliveryCenter")]
    [Relation(typeof(EDCommodity), "DDE")]
    public class EDCommodity : EStatus,  IRelatedRoles
    {
        [One(ViewNameofDeliveryCenter.DeliveryCenter)]public DeliveryCenter DeliveryCenter { get; set; }
        [One(ViewNameofDeliveryCenter.DCommodity)]public DCommodity DCommodity {get; set;}
        [One(ViewNameofDeliveryCenter.MDCommodity)]public MDCommodity MDCommodity {get; set;}
        [Detail]public string DeliveryCenterId {get; set;}
        [Detail]public string DCommodityId {get; set;}
        [Detail]public string MDCommodidtyId {get; set;}
        public EDCommodity()
        {
            DeliveryCenter = new();
        }

    }

    // public class DeliveryInfo
    // {
    //     public string Mark {get; set;} // 새벽, 일반
    //     public string OrdererId {get; set;}
    // }
}