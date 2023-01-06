using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using BusinessData.ofDataAccessLayer.ofTrade.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofDataAccessLayer.ofTrade.ofDbContext
{
    public class BackUpTradeDbContext : DbContext
    {
        private string _connectionstring;
        public BackUpTradeDbContext(DbContextOptions<TradeDbContext> options)
            : base(options)
        {

        }
        public BackUpTradeDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.TradeDbConnection; }
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
}