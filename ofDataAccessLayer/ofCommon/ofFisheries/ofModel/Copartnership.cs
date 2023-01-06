using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using System.Collections.Generic;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofFisheries.ofModel
{
    [DataContext(typeof(FisheriesDbContext), DbConnectionString.FisheriesDbConnection)]
    [Relation(typeof(Copartnership), nameof(Copartnership))]
    public class Copartnership : Entity
    {
        public List<string> FisheriesId { get; set; }
        
    }
}
