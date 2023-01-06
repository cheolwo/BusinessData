namespace BusinessData.ofWarehouse.Model
{
    // 주문이 들어오면 창고에서 출고할 수 있도록 데이터 구조를 만들어두어야돼.
    // 판매상품을 들고하기 전에 WCommodityId가 저장되도록 만들 필요가 있어.

    //public class OutgoingCommodity 
    //{
    //    [Key] public int Id { get; set; }
    //    public string OrderId { get; set; }
    //    public int Quantity { get; set; }

    //    // 책임사람
    //    public DateTime? WaitingTime { get; set; }
    //    public DateTime? PickingTime { get; set; }
    //    public DateTime? PackingTime { get; set; }
    //    public DateTime? OutgoingTime { get; set; }
    //    public DateTime? DeliveringTime { get; set; }

    //    public string PickingUser { get; set; }
    //    public string PackingUser { get; set; }
    //    public string OutgoingUser { get; set; }
    //    public string DeliveringUser { get; set; }

    //    public Pack Pack { get; set; }
    //    public WCommodity WCommodity { get; set; }
    //    public Order Order {get; set;}

    //    public IList<ImageofInfo> ImageofWCommodities {get; set;}
    //}
}
