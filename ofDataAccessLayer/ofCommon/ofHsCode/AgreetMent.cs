using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofHsCode.ofDbContext;
using System;
using System.Collections.Generic;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofHsCode
{
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(AgreetMentTaxRate), "AgreetMent")]
    public class AgreetMent : Entity
    {
        // Name is KindsofAgreetMent
        public DateTime StartTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public List<string> CoutryName { get; set; }
    }
}
