using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using BusinessData.ofDataAccessLayer.ofOrder.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofDataAccessLayer.ofOrder.ofDbContext
{
    public class OrderDbContext : DbContext
    {
        private string _connectionstring;
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            :base(options)
        {

        }
        public OrderDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.OrderDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring, options => options.EnableRetryOnFailure());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new OrderCenterConfiguration());
            modelBuilder.ApplyConfiguration(new SOCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MOCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EOCommodityConfiguration());
        }
    }
    public class OrderCenterConfiguration : CenterConfiguration<OrderCenter>
    {
        public override void Configure(EntityTypeBuilder<OrderCenter> builder)
        {
            base.Configure(builder);
            builder.ToTable("OrderCenter");
            //builder.HasMany(e => e.OCommodities).WithOne(e => e.OrderCenter);
            //builder.HasMany(e => e.SOCommodities).WithOne(e => e.OrderCenter);
            //builder.HasMany(e => e.MOCommodities).WithOne(e => e.OrderCenter);
            //builder.HasMany(e => e.EOCommodities).WithOne(e => e.OrderCenter);
            
        }
    }
    public class OCommodityConfiguration : CommodityConfiguration<OCommodity>
    {
        public override void Configure(EntityTypeBuilder<OCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("OCommodity");
            //builder.HasMany(e => e.SOCommodities).WithOne(e => e.OCommodity);
            //builder.HasMany(e => e.MOCommodities).WithOne(e => e.OCommodity);
            //builder.HasMany(e => e.EOCommodities).WithOne(e => e.OCommodity);
            //builder.HasOne(e => e.OrderCenter).WithMany(e => e.OCommodities);
        }
    }
    public class SOCommodityConfiguration : SStatusConfiguration<SOCommodity>
    {
        public override void Configure(EntityTypeBuilder<SOCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("SOCommodity");
            //builder.HasMany(e => e.MOCommodities).WithOne(e => e.SOCommodity);
            //builder.HasOne(e => e.OrderCenter).WithMany(e => e.SOCommodities);
            //builder.HasOne(e => e.OCommodity).WithMany(e => e.SOCommodities);
        }
    }
    public class MOCommodityConfiguration : MStatusConfiguration<MOCommodity>
    {
        public override void Configure(EntityTypeBuilder<MOCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("MOCommodity");
            //builder.HasMany(e => e.EOCommodities).WithOne(e => e.MOCommodity);
            //builder.HasOne(e => e.OrderCenter).WithMany(e => e.MOCommodities);
            //builder.HasOne(e => e.OCommodity).WithMany(e => e.MOCommodities);
        }
    }
    public class EOCommodityConfiguration : EStatusConfiguration<EOCommodity>
    {
        public override void Configure(EntityTypeBuilder<EOCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("EOCommodity");
            //builder.HasOne(e => e.MOCommodity).WithMany(e => e.EOCommodities);
            //builder.HasOne(e => e.OrderCenter).WithMany(e => e.EOCommodities);
            //builder.HasOne(e => e.OCommodity).WithMany(e => e.EOCommodities);
        }
    }
}
