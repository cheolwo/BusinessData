using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using BusinessData.ofDataAccessLayer.ofProduct.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofProduct.ofDbContext
{
    public class ProductDbContext : DbContext
    {
        private string _connectionstring;
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {

        }
        public ProductDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.ProductDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductCenterConfiguration());
            modelBuilder.ApplyConfiguration(new PCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new SPCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MPCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EPCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductLandConfiguration());
            modelBuilder.ApplyConfiguration(new ProducterConfiguration());
        }
    }
    public class ProductLandConfiguration : EntityConfiguration<ProductLand>
    {
        public override void Configure(EntityTypeBuilder<ProductLand> builder)
        {
            base.Configure(builder);
        }
    }
    public class PCommodityConfiguration : CommodityConfiguration<PCommodity>
    {
        public override void Configure(EntityTypeBuilder<PCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("PCommodity");
        }
    }
    public class ProductCenterConfiguration : CenterConfiguration<ProductCenter>
    {
        public override void Configure(EntityTypeBuilder<ProductCenter> builder)
        {
            base.Configure(builder);
            builder.ToTable("ProductCenter");
        }
    }
    public class ProducterConfiguration : CenterConfiguration<Producter>
    {
        public override void Configure(EntityTypeBuilder<Producter> builder)
        {
            base.Configure(builder);
            builder.ToTable("Producter");
        }
    }
    public class SPCommodityConfiguration : StatusConfiguration<SPCommodity>
    {
        public override void Configure(EntityTypeBuilder<SPCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("SPCommodity");
        }
    }
    public class MPCommodityConfiguration : StatusConfiguration<MPCommodity>
    {
        public override void Configure(EntityTypeBuilder<MPCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("MPCommodity");
        }
    }
    public class EPCommodityConfiguration : StatusConfiguration<EPCommodity>
    {
        public override void Configure(EntityTypeBuilder<EPCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("EPCommodity");
        }
    }
}