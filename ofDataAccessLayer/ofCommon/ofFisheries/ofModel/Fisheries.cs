using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using System.Collections.Generic;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofFisheries.ofModel
{
    [DataContext(typeof(FisheriesDbContext), DbConnectionString.FisheriesDbConnection)]
    [Relation(typeof(Fisheries), nameof(Fisheries))]
    public class Fisheries : Center
    { 
        public List<MFishCommodity> MFishCommodities { get; set; }
        public List<EFishCommodity> EFishCommodities { get; set; }
        public List<SFishCommodity> SFishCommodities { get; set; }
        public List<FishCommodity> FishCommodities { get; set; }
    }
}
