using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using BusinessData.ofDataAccessLayer.ofMarket.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace BusinessData.ofDataAccessLayer.ofMarket.ofDbContext
{
    public class MarketDbContext : DbContext
    {
        private string _connectionstring;
        public MarketDbContext(DbContextOptions<MarketDbContext> options)
            : base(options)
        {

        }
        public MarketDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.MarketDbConnection; }
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
    }
    public class MCommodityConfiguration<TMCommodity> : CommodityConfiguration<TMCommodity> where TMCommodity : MCommodity
    {
        public override void Configure(EntityTypeBuilder<TMCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class MarketConfiguration<TMarket> : CenterConfiguration<TMarket> where TMarket : Market
    {
        public override void Configure(EntityTypeBuilder<TMarket> builder)
        {
            base.Configure(builder);
        }
    }
    public class SMCommodityConfiguration<TSMCommodity> : StatusConfiguration<TSMCommodity> where TSMCommodity : SMCommodity
    {
        public override void Configure(EntityTypeBuilder<TSMCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class MMCommodityConfiguration<TMMCommodity> : StatusConfiguration<TMMCommodity> where TMMCommodity : MMCommodity
    {
        public override void Configure(EntityTypeBuilder<TMMCommodity> builder)
        {
            base.Configure(builder);
        }
    }
    public class EMCommodityConfiguration<TEMCommodity> : StatusConfiguration<TEMCommodity> where TEMCommodity : EMCommodity
    {
        public override void Configure(EntityTypeBuilder<TEMCommodity> builder)
        {
            base.Configure(builder);
        }
    }
}