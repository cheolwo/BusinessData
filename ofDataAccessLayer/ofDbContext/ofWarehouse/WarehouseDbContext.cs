using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext
{
    public class WarehouseDbContext : DbContext
    {
        private string _connectionstring;
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options)
            : base(options)
        {

        }
        public WarehouseDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.WarehouseDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WarehouseConfiguration());
            modelBuilder.ApplyConfiguration(new WCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new SWCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MWCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new EWCommodityConfiguration());
        }
        public DbSet<DividedTag> DividedTags {get; set;}
        public DbSet<IncomingTag> IncomingTags {get; set;}
        public DbSet<LoadFrame> LoadFrames {get; set;}
        public DbSet<WorkingDesk> WorkingDesks {get; set;}
        public DbSet<DotBarcode> DotBarcodes { get; set; }
    }
    public class WorkingDeskConfiguraion : EntityConfiguration<WorkingDesk>
    {
        public override void Configure(EntityTypeBuilder<WorkingDesk> builder)
        {
            base.Configure(builder);
        }
    }
    public class DotBarcodeConfiguration : EntityConfiguration<DotBarcode>
    {
        public override void Configure(EntityTypeBuilder<DotBarcode> builder)
        {
            base.Configure(builder);
        }
    }
    public class WarehouseConfiguration : CenterConfiguration<Warehouse>
    {
        public override void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.CenterIPAddresses);
            builder.ToTable("Warehose");
        }
    }
    public class WCommodityConfiguration : CommodityConfiguration<WCommodity>
    {
        public override void Configure(EntityTypeBuilder<WCommodity> builder)
        {
            builder.ToTable("WCommodity");
            base.Configure(builder);
        }
    }
    public class SWCommodityConfiguration : SStatusConfiguration<SWCommodity>
    {
        public override void Configure(EntityTypeBuilder<SWCommodity> builder)
        {
            builder.ToTable("SWCommodity");
            base.Configure(builder);
        }
    }
    public class MWCommodityConfiguration : MStatusConfiguration<MWCommodity>
    {
        public override void Configure(EntityTypeBuilder<MWCommodity> builder)
        {
            builder.ToTable("MWCommodity");
            base.Configure(builder);
        }
    }
    public class EWCommodityConfiguration : EStatusConfiguration<EWCommodity>
    {
        public override void Configure(EntityTypeBuilder<EWCommodity> builder)
        {
            builder.ToTable("EWCommodity");
            base.Configure(builder);
        }
    }
    
    
}