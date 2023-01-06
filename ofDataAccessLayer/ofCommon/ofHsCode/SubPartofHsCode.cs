using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofHsCode.ofDbContext;
using System.Collections.Generic;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofHsCode
{
    //류
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(SubPartofHsCode), "SubPartofHsCode")]
    public class SubPartofHsCode : Entity
    {
        public HsCodePart HsCodePart { get; set; }
        public List<PracticalHsCode> PracticalHsCodes { get; set; }
    }
}
