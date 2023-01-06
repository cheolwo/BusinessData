using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessData.ofDataAccessLayer.Trade.ModelofDoc
{
    public class PackingList
    {
        public string Seller { get; set; }
        public string Consignee { get; set; }
        public string DepartureDate { get; set; }
        public string VesselFlight { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string InvoiceNoAndDate { get; set; }
        public string LCNoAndDate { get; set; }
        public string Buyer { get; set; }
        public string OtherReferences { get; set; }
        public string TermsofDeliveryAndPayment { get; set; }
        public string Signedby { get; set; }

        public List<PackingCommodity> PackingCommodities {get; set;}
    }

    public class PackingCommodity
    {
        public string ShippingMarks { get; set; }
        public string NoKindofPackages { get; set; }
        public string GoodsDescription { get; set; }
        public string Quantity { get; set; }
        public string UnitKg { get; set; }
        public string Amount { get; set; }
    }

    public enum PackingListCellPosSeller { Row = 5, Column = 1 }
    public enum PackingListCellPosInvoiceNoAndDate { Row = 5, Column = 17 }
    public enum PackingListCellPosConsignee { Row = 10, Column = 1 }
    public enum PackingListCellPosLCNoAndDate { Row = 7, Column = 17 }
    public enum PackingListCellPosDepartureDate { Row = 18, Column = 1 }
    public enum PackingListCellPosVesselFlight { Row = 18, Column = 1 }
    public enum PackingListCellPosFrom { Row = 20, Column = 12 }
    public enum PackingListCellPosTo { Row = 22, Column = 4 }
    public enum PackingListCellPosBuyer { Row = 10, Column = 17 }
    public enum PackingListCellPosOtherRefernces { Row = 15, Column = 17 }
    public enum PackingListCellPosTermsofDeliveryAndPayment { Row = 21, Column = 17 }
    public enum PackingListCellPosSignedby { Row = 32, Column = 24 }
    public enum PackingListCellPosShippingMarks { Row = 24, Column = 1 }
    public enum PackingListCellPosKindofPackages { Row = 24, Column = 7 }
    public enum PackingListCellPosGoodDescription { Row = 24, Column = 15 }
    public enum PackingListCellPosQuantity { Row = 24, Column = 22 }
    public enum PackingListCellPosUnitKg { Row = 24, Column = 26 }
    public enum PackingListCellPosAmountKg { Row = 24, Column = 30 }
   
}
