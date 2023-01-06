using System;
using System.ComponentModel.DataAnnotations;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofDataContext.ofBusiness;
using BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.Model
{
    [DataContext(typeof(WarehouseDbContext), DbConnectionString.WarehouseDbConnection, typeof(WarehouseDataContext))]
    public class Transaction
   {
       [Key] public int Id {get; set;}
       public string Buyer {get; set;} 
       public string Seller {get; set;}
       public string Incorterms {get; set;}

       public bool WarehouseApprove {get; set;}
       public bool SellerApprove {get; set;}  
       public bool BuyerAppreve {get; set;}

       public double Width {get; set;}
       public double Height {get; set;}
       public double Length { get; set; }

       public double Weight {get; set;}     // 개당 무게
       public double PriceperPiece {get; set;} // 개당 가격 

       public string NameofCommodity {get; set;}
       public string Barcode {get; set;}
       public int Quantity {get; set;}
       public DateTime DateTime {get; set;}
       public Warehouse Warehouse {get; set;}   // 도착지
   }
}
