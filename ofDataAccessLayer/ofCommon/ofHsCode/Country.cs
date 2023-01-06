using BusinessData.ofDataAccessLayer.ofCommon.ofHsCode.ofDbContext;
using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofHsCode
{
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(Country), "Country")] 
    public class Country : Entity
    {
        public List<HsCodePart> HsCodePart { get; set; }
        public List<SubPartofHsCode> SubPartofHsCode { get; set; }
        public List<PracticalHsCode> PracticalHsCode { get; set; }
        public List<AgreetMent> AgreetMents { get; set; } // Json
    }
}
