using BusinessData.ofDataAccessLayer.ofCommon;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofDataAccessLayer.ofOrder.ofDbContext
{
    public class BackUpOrderDbContext : DbContext
    {
        private string _connectionstring;
        public BackUpOrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
        {

        }
        public BackUpOrderDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.OrderDbConnection; }
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
}
