using BusinessData.ofDataAccessLayer.ofCommon;
using System.ComponentModel.DataAnnotations;

namespace BusinessData.ofDataAccessLayer.ofMarket.ofModel
{
    public class DetailofMCommodity : Entity
    {   
        public string Brand { get; set; }
        public string Menufactured { get; set; }
        
        [Required] public int AuthenticateCode { get; set; }
        [Required] public int ImportCode { get; set; }
        [Required] public bool PossibleUnder20 { get; set; }
        [Required] public int MaximumPossibleQuantity { get; set; } // per Individual
        [Required] public int DurationTime { get; set; } // 단위 : 일
        [Required] public bool IsVAT { get; set; }
        public MCommodity MCommodity {get; set;}
        public DetailofMCommodity()
        {
            MCommodity = new();
        }
    }

    public enum Authenticate { 인증대상 = 0, 상세페이지별도표기 = 1, 인증대상아님 = 2 }
    public enum Import { Import = 0, Agency = 1 }
}
