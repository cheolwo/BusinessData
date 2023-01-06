using BusinessData.ofDataAccessLayer.ofCommon.ofHsCode.ofDbContext;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofHsCode.ofRepository
{
    public class CountryRepository : EntityDataRepository<Country>
    {
        public CountryRepository(HsDbContext hsDbContext)
            : base(hsDbContext) { }
    }
    public class AgreetMentRepository : EntityDataRepository<AgreetMent>
    {
        public AgreetMentRepository(HsDbContext hsDbContext)
            : base(hsDbContext) { }
    }
    public class HsCodePartRepository : EntityDataRepository<HsCodePart> 
    {
        public HsCodePartRepository(HsDbContext hsDbContext)
           : base(hsDbContext) { }
    }
    public class SubPartofHsCodeRepository : EntityDataRepository<SubPartofHsCode> 
    {
        public SubPartofHsCodeRepository(HsDbContext hsDbContext)
           : base(hsDbContext) { }
    } 
    public class PracticalHsCodeRepository : EntityDataRepository<PracticalHsCode> 
    {
        public PracticalHsCodeRepository(HsDbContext hsDbContext)
           : base(hsDbContext) { }
    }
    public class SubPracticalHsCodeRepository : EntityDataRepository<SubPracticalHsCode>
    {
        public SubPracticalHsCodeRepository(HsDbContext hsDbContext)
           : base(hsDbContext) { }
    }
    public class DetailPracticalHsCodeRepository : EntityDataRepository<DetailPracticalHsCode> 
    {
        public DetailPracticalHsCodeRepository(HsDbContext hsDbContext)
           : base(hsDbContext) { }
    }
    public class ClaranceInfoofHsCodeRepostiroy : EntityDataRepository<ClearanceInfoofHsCode> 
    {
        public ClaranceInfoofHsCodeRepostiroy(HsDbContext hsDbContext)
           : base(hsDbContext) { }
     }
    public class ConfirmationByTheCutomerOfficierRepostiory : EntityDataRepository<ConfirmationByTheCustomsOfficer> 
    {
        public ConfirmationByTheCutomerOfficierRepostiory(HsDbContext hsDbContext)
           : base(hsDbContext) { }
    }
}
