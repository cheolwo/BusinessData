using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessData.ofDataAccessLayer.ofTrade.ofModel
{
    public class TradeInfo 
    {
        [Key] public int Id { get; set; }
        public string UserId {get; set;}
        public List<Official> Officials {get; set;}
        public TradeInfo()
        {
            Officials = new();
        }
    }
}
