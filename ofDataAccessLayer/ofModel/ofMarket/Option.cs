using System.ComponentModel.DataAnnotations;

namespace BusinessData.ofDataAccessLayer.ofMarket.ofModel
{
    public class Option
    {
        [Key] public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }   
        public string NormalPrice { get; set; }
        public string SalePrice { get; set; }
        public string ModelNo { get; set; }
        public string CommotityBarcode { get; set; }
        public MCommodity MCommodity { get; set; }
        public Option()
        {
            MCommodity = new();
        }
    }
}
