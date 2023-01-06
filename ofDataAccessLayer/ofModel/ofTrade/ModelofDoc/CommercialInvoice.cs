using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessData.ofDataAccessLayer.Trade.ModelofDoc
{
    public class CommercialInvoice
    {
        [Key] public int Id { get; set; }
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

        public List<InvoiceCommodity> InvoiceCommodities { get; set; }
    }

    public class InvoiceCommodity
    {
        [Key] public int Id { get; set; }
        public string ShippingMarks { get; set; }
        public string NoKindofPackages { get; set; }
        public string GoodsDescription { get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string Amount { get; set; }
    }

    public enum CommercialInvoiceCellPosSeller { Row = 5, Column = 1 }
    public enum CommercialInvoiceCellPosInvoiceNoAndDate { Row = 4, Column = 16 }
    public enum CommercialInvoiceCellPosConsignee { Row = 10, Column = 1 }
    public enum CommercialInvoiceCellPosLCNoAndDate { Row = 7, Column = 17 }
    public enum CommercialInvoiceCellPosDepartureDate { Row = 18, Column = 1 }
    public enum CommercialInvoiceCellPosVesselFlight { Row = 18, Column = 1 }
    public enum CommercialInvoiceCellPosFrom { Row = 20, Column = 12 }
    public enum CommercialInvoiceCellPosTo { Row = 22, Column = 4 }
    public enum CommercialInvoiceCellPosBuyer { Row = 10, Column = 17 }
    public enum CommercialInvoiceCellPosOtherRefernces { Row = 15, Column = 17 }
    public enum CommercialInvoiceCellPosTermsofDeliveryAndPayment { Row = 21, Column = 17 }
    public enum CommercialInvoiceCellPosSignedby { Row = 32, Column = 24}
    public enum CommercialInvoiceCellPosShippingMarks { Row = 24, Column = 1}
    public enum CommercialInvoiceCellPosKindofPackages { Row = 24, Column = 7}
    public enum CommercialInvoiceCellPosGoodDescription { Row = 24, Column = 15}
    public enum CommercialInvoiceCellPosQuantity { Row = 24, Column = 22}
    public enum CommercialInvoiceCellPosUnitPrice { Row = 24, Column = 26}
    public enum CommercialInvoiceCellPosAmount { Row = 24, Column = 30}
}
