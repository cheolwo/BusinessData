using BusinessData.ofDataAccessLayer.ofCommon.ofFisheries.ofModel;
using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessData.ofDataAccessLayer.ofCommon
{
    public class FisheriesDbContext : DbContext
    {
        protected string _connectionstring;
        public FisheriesDbContext(DbContextOptions<FisheriesDbContext> options)
            :base(options)
        {

        }
        public FisheriesDbContext(string connectionString)
        {
            _connectionstring = connectionString;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DbConnectionString.FisheriesDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        // 이 부분에서 DotBaroce 같은 게 테이블로서 만들어지는지를 잘 모르겠어.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CopartnershipConfiguration());
            modelBuilder.ApplyConfiguration(new FisheriesConfiguration());
            modelBuilder.ApplyConfiguration(new FishCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new SFishCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MFishCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EFishCommodityConfiguration());
        }
    }
    public class CopartnershipConfiguration : EntityConfiguration<Copartnership>
    {
        public override void Configure(EntityTypeBuilder<Copartnership> builder)
        {
            base.Configure(builder);
            builder.ToTable("Copartnership");
            builder.Ignore(c => c.ChangedUsers);
            builder.Property(c => c.FisheriesId).HasConversion(
                v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                v => JsonConvert.DeserializeObject<List<string>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                new ValueComparer<List<string>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
            // 필요없는 속성의 경우 무시할 로직을 작성할 필요가 있음.
        }
    }
    public class FisheriesConfiguration : CenterConfiguration<Fisheries>
    {
        public override void Configure(EntityTypeBuilder<Fisheries> builder)
        {
            base.Configure(builder);
            builder.ToTable("Fisheries");
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.CenterMacAddresses);
            builder.Ignore(c=>c.CenterIPAddresses);
            // 필요없는 속성의 경우 무시할 로직을 작성할 필요가 있음.
        }
    }
    public class FishCommodityConfiguration : CommodityConfiguration<FishCommodity>
    {
        public override void Configure(EntityTypeBuilder<FishCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("FishCommodity");
            builder.Ignore(c => c.ChangedUsers);
        }
    }
    public class SFishCommodityConfiguration : StatusConfiguration<SFishCommodity>
    {
        public override void Configure(EntityTypeBuilder<SFishCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("SFishCommodity");
            builder.Ignore(c => c.ChangedUsers);
        }
    }
    public class MFishCommodityConfiguration : StatusConfiguration<MFishCommodity>
    {
        public override void Configure(EntityTypeBuilder<MFishCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("MFishCommodity");
            builder.Ignore(c => c.ChangedUsers);
        }
    }
    public class EFishCommodityConfiguration : StatusConfiguration<EFishCommodity>
    {
        public override void Configure(EntityTypeBuilder<EFishCommodity> builder)
        { 
            base.Configure(builder);
            builder.ToTable("EFishCommodity");
            builder.Ignore(c => c.ChangedUsers);
        }
    }
}