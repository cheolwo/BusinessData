using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofDataAccessLayer.ofMarket.ofDbContext
{
    public class BackUpMarketDbContext : DbContext
    {
        private string _connectionstring;
        public BackUpMarketDbContext(DbContextOptions<MarketDbContext> options)
            : base(options)
        {

        }
        public BackUpMarketDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.MarketDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MarketConfiguration<Market>());
            modelBuilder.ApplyConfiguration(new MCommodityConfiguration<MCommodity>());
            modelBuilder.ApplyConfiguration(new SMCommodityConfiguration<SMCommodity>());
            modelBuilder.ApplyConfiguration(new MMCommodityConfiguration<MMCommodity>());
            modelBuilder.ApplyConfiguration(new EMCommodityConfiguration<EMCommodity>());
        }
        public DbSet<PlatMarket> PlatMarkets { get; set; }
    }
}