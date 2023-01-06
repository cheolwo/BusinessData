using BusinessData.ofCommon.ofKapt;
using BusinessData.ofDataAccessLayer.ofCommon.ofKApt.ofDbContext;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;

namespace BusinessData.ofCommon.ofKAprt.ofRepository
{
    public class KAptBasicInfoRepository : EntityDataRepository<KAptBasicInfo>
    {
        public KAptBasicInfoRepository(KAptDbContext KAprtDbContext)
            : base(KAprtDbContext) { }
    }
}