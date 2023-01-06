using BusinessData.ofDataAccessLayer.ofCommon.ofKamis.ofModel;
using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofKamis.ofDbContext
{
    public class KamisDbContext : DbContext
    {
        private string _connectionstring;
        public KamisDbContext(DbContextOptions<KamisDbContext> options)
            : base(options)
        {

        }
        public KamisDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            if(_connectionstring is null) { _connectionstring = DbConnectionString.KamisDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KamisPartConfiguration());
            modelBuilder.ApplyConfiguration(new KamsiCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new KamisKindofCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new KamisCountryAdministrationPartConfiguration());
            modelBuilder.ApplyConfiguration(new KamisMarketConfiguration());
            modelBuilder.ApplyConfiguration(new KamisWholeSalePriceConfiguration());
            modelBuilder.ApplyConfiguration(new KamisRetailPriceConfiguration());
            modelBuilder.ApplyConfiguration(new KamisGradeConfiguration());
        }
    }
    public class KamisEntityConfiguration<TEntity> : EntityConfiguration<TEntity> where TEntity : KamisEntity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.UserId);
            builder.Ignore(c => c.CreateTime);
        }
    }
    public class KamisPartConfiguration : KamisEntityConfiguration<KamisPart>
    {
        public override void Configure(EntityTypeBuilder<KamisPart> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.UserId);
            builder.Ignore(c => c.CreateTime);
        }
    }
    public class KamisGradeConfiguration : KamisEntityConfiguration<KamisGrade>
    {
        public override void Configure(EntityTypeBuilder<KamisGrade> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.UserId);
            builder.Ignore(c => c.CreateTime);
        }
    }
    public class KamsiCommodityConfiguration : KamisEntityConfiguration<KamisCommodity>
    {
        public override void Configure(EntityTypeBuilder<KamisCommodity> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.UserId);
            builder.Ignore(c => c.CreateTime);
            builder.HasOne(p => p.KamisPart).WithMany(c => c.KamisCommodities).HasForeignKey(p => p.KamisPartId);
        }
    }
    public class KamisKindofCommodityConfiguration : KamisEntityConfiguration<KamisKindofCommodity>
    {
        public override void Configure(EntityTypeBuilder<KamisKindofCommodity> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.UserId);
            builder.Ignore(c => c.CreateTime);
            builder.HasOne(c => c.KamisCommodity).WithMany(k => k.KamisKindsofCommodity).HasForeignKey(c => c.KamisCommodityId);
            builder.HasOne(c => c.KamisPart).WithMany(k => k.KamisKindsofCommodities).HasForeignKey(c => c.KamisPartId);
        }
    }
    public class KamisCountryAdministrationPartConfiguration : KamisEntityConfiguration<KamisCountryAdministrationPart>
    {
        public override void Configure(EntityTypeBuilder<KamisCountryAdministrationPart> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.UserId);
            builder.Ignore(c => c.CreateTime);
        }
    }
    public class KamisMarketConfiguration : KamisEntityConfiguration<KamisMarket>
    {
        public override void Configure(EntityTypeBuilder<KamisMarket> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.UserId);
            builder.Ignore(c => c.CreateTime);
            builder.HasOne(o => o.KamisCountryAdministrationPart).WithMany(m => m.KamisMakrets).HasForeignKey(o => o.KamisCountryAdministrationPartId);
        }
    }
    public class KamisWholeSalePriceConfiguration : KamisEntityConfiguration<KamisWholeSalePrice>
    {
        public override void Configure(EntityTypeBuilder<KamisWholeSalePrice> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.Container);
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.UserId);
            builder.Ignore(c => c.CreateTime);
            builder.Ignore(c => c.ImageofInfos);
            builder.HasOne(o => o.KamisMarket).WithMany(m => m.KamisWholeSalePrices).HasForeignKey(o => o.KamisMarketId);
            builder.HasOne(o => o.KamisKindofCommodity).WithMany(m => m.KamisWholeSalePrices).HasForeignKey(o => o.KamisKindofCommodityId);
        }
    }
    public class KamisRetailPriceConfiguration : KamisEntityConfiguration<KamisRetailPrice>
    {
        public override void Configure(EntityTypeBuilder<KamisRetailPrice> builder)
        {   
            base.Configure(builder);
            builder.Ignore(c => c.Container);
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.UserId);
            builder.Ignore(c => c.CreateTime);
            builder.Ignore(c => c.ImageofInfos);
            builder.HasOne(o => o.KamisMarket).WithMany(m => m.KamisRetailPrices).HasForeignKey(o => o.KamisMarketId);
            builder.HasOne(o => o.KamisKindofCommodity).WithMany(m => m.KamisRetailPrices).HasForeignKey(o => o.KamisKindofCommodityId);
        }
    }
    
}