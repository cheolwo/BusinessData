using BusinessData.ofDataAccessLayer.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofDataAccessLayer.ofCommon.ofAttribute;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofHsCode
{
    [DataContext(typeof(HsDbContext), DbConnectionString.HsDbConnection)]
    [Relation(typeof(DetailPracticalHsCode), "DetailPracticalHsCode")]
    public class DetailPracticalHsCode : Entity
    {
        public string UsName { get; set; }
        public string KoName { get; set; }
        public string QuantityUnits { get; set; }
        public string WeightUnits { get; set; }
        public SubPracticalHsCode SubPracticalHsCode { get; set; }
        public ClearanceInfoofHsCode ClearanceInfoofHsCode { get; set; }
        public ConfirmationByTheCustomsOfficer Confirmationbythecustomsofficer { get; set; }
        //public DetailPracticalHsCode()
        //{
        //    PracticalHsCode = new();
        //    ClearanceInfoofHsCode = new();
        //    Confirmationbythecustomsofficer = new();
        //}
        public void Clear()
        {
            SubPracticalHsCode.Clear();
            ClearanceInfoofHsCode.Clear();
        }
    }
}
