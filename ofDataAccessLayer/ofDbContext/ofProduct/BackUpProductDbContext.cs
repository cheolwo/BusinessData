using BusinessData.ofDataAccessLayer.ofCommon;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofProduct.ofDbContext
{
    public class BackUpProductDbContext : DbContext
    {
        private string _connectionstring;
        public BackUpProductDbContext(DbContextOptions<ProductDbContext> options)
            : base(options)
        {

        }
        public BackUpProductDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.ProductDbConnection; }
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
}