using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessData.ofDataAccessLayer.Trade.ModelofDoc
{
    public class PurchaseOrderSheet
    {
        public Receiver Receiver { get; set; }
        public Caller Caller { get; set; }
        public List<OrderCommodity> OrderCommodities { get; set; }

        public string 납기일자 { get; set; }
        public string 납품처 { get; set; }
        public double 합계 { get; set; }
    }

    public class Receiver
    {      
        public string 수신 { get; set; }
        public string 수신TEL { get; set; }
        public string 수신FAX { get; set; }
        public string 내용 { get; set; }
        public string 결재조건 { get; set; }
        public string 발주일자 { get; set; }
    }

    public class Caller
    {
        public string 사업자등록번호 { get; set; }
        public string 대표 { get; set; }
        public string 업태 { get; set; }
        public string 종목 { get; set; }
        public string 주소 { get; set; }
        public string 발신TEL { get; set; }
        public string 발신FAX { get; set; }
    }

    public class OrderCommodity
    {
        public string Description { get; set; }
        public string Specification { get; set; }
        public string Unit { get; set; }
        public string Quantity { get; set; }
        public string 단가 { get; set; }
        public string 금액 { get; set; }
    }
}
