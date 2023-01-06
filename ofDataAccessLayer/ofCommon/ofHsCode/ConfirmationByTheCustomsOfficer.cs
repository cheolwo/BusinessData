using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;
using BusinessData.ofDataAccessLayer.ofCommon.ofHsCode.ofDbContext;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofHsCode
{
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(ConfirmationByTheCustomsOfficer), "ConfirmationByTheCustomsOfficer")]
    public class ConfirmationByTheCustomsOfficer : Entity
    {
        public string ClassificationofImportAndExport { get; set; }
        public DateTime ApplicationEndDate { get; set; }
        public DateTime ApplicationStartDate { get; set; }
        public string RelatedLaws { get; set; }
        public string RequirementConfirmationDocumentName { get; set; }
        [ForeignKey("HsCode")]  public DetailPracticalHsCode DetailPracticalHsCode { get;set; }
    }
}
