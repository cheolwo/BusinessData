using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofHsCode.ofDbContext;
using System.Collections.Generic;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofHsCode
{
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(SubPracticalHsCode), "SubPracticalHsCode")]
    // 소호
    public class SubPracticalHsCode : Entity
    {
        public string UsName { get; set; }
        public PracticalHsCode PracticalHsCode { get; set; }
        public List<DetailPracticalHsCode> DetailPracticalHsCodes {get; set;}
        public void Clear()
        {
            PracticalHsCode.Clear();
            DetailPracticalHsCodes.Clear();
        }
    }
}
