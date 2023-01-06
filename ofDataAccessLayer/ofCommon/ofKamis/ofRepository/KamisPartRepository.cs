using BusinessData.ofDataAccessLayer.ofCommon.ofKamis.ofDbContext;
using BusinessData.ofDataAccessLayer.ofCommon.ofKamis.ofModel;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofKamis.ofRepository
{
    public class KamisGradeRepository : EntityDataRepository<KamisGrade>
    {
        public KamisGradeRepository(KamisDbContext KamisDbContext)
            : base(KamisDbContext) { }
    }
    public class KamisPartRepository : EntityDataRepository<KamisPart>
    {
        public KamisPartRepository(KamisDbContext KamisDbContext)
            : base(KamisDbContext) { }
    }
    public class KamisCommodityRepository : EntityDataRepository<KamisCommodity>
    {
        public KamisCommodityRepository(KamisDbContext KamisDbContext)
            : base(KamisDbContext) { }
    }
    public class KamisKindofCommodityRepository : EntityDataRepository<KamisKindofCommodity>
    {
        public KamisKindofCommodityRepository(KamisDbContext KamisDbContext)
            : base(KamisDbContext) { }
    }
    public class KamisCountryAdministrationPartRepository : EntityDataRepository<KamisCountryAdministrationPart>
    {
        public KamisCountryAdministrationPartRepository(KamisDbContext KamisDbContext)
            : base(KamisDbContext) { }
    }
    public class KamisMarketRepository : EntityDataRepository<KamisMarket>
    {
        public KamisMarketRepository(KamisDbContext KamisDbContext)
            : base(KamisDbContext) { }
    }
    public class KamisWholeSalePriceRepository : EntityDataRepository<KamisWholeSalePrice>
    {
        public KamisWholeSalePriceRepository(KamisDbContext KamisDbContext)
            : base(KamisDbContext) { }
    }
    public class KamisRetailPriceRepository : EntityDataRepository<KamisRetailPrice>
    {
        public KamisRetailPriceRepository(KamisDbContext KamisDbContext)
            : base(KamisDbContext) { }
    }
}
