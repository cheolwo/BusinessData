using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessData.ofDataAccessLayer.ofTrade.ofModel
{
    public class Official
    {
        [Key] public int Id { get; set; }
        public string Role {get;set;}
        public string Name {get;set;}        
        public string Tel {get; set;}
        public string Pax {get; set;}
        public string Address {get; set;}
        public string NumberofCompanyRegistration {get; set;}
        public string Email {get; set;}
        public string HomepageUrl {get; set;}

        public List<TCommodity> TCommodities {get; set;}
        public TradeInfo TradeInfo { get; set; }
        public Official()
        {
            TCommodities = new();
            TradeInfo = new();
        }
    }
}
