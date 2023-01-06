using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofDataAccessLayer.ofTrade.ofDbContext
{
    public class TradeDbContext : DbContext
    {
        private string _connectionstring;
        public TradeDbContext(DbContextOptions<TradeDbContext> options)
            : base(options)
        {

        }
        public TradeDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.TradeDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TradeCenterConfiguration());
            modelBuilder.ApplyConfiguration(new TCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new STCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new MTCommodityConfiguration());
            modelBuilder.ApplyConfiguration(new ETCommodityConfiguration());
        }
    }
    public class TCommodityConfiguration : CommodityConfiguration<TCommodity>
    {
        public override void Configure(EntityTypeBuilder<TCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("TCommodity");
        }
    }
    public class TradeCenterConfiguration : CenterConfiguration<TradeCenter>
    {
        public override void Configure(EntityTypeBuilder<TradeCenter> builder)
        {
            base.Configure(builder);
            builder.ToTable("TradeCenter");
        }
    }
    public class STCommodityConfiguration : StatusConfiguration<STCommodity>
    {
        public override void Configure(EntityTypeBuilder<STCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("STCommodity");
        }
    }
    public class MTCommodityConfiguration : StatusConfiguration<MTCommodity>
    {
        public override void Configure(EntityTypeBuilder<MTCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("MTCommodity");
        }
    }
    public class ETCommodityConfiguration : StatusConfiguration<ETCommodity>
    {
        public override void Configure(EntityTypeBuilder<ETCommodity> builder)
        {
            base.Configure(builder);
            builder.ToTable("ETCommodity");
        }
    }
}