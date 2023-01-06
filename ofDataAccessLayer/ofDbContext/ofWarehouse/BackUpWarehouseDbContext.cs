using Microsoft.EntityFrameworkCore;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofWarehouse.Model;

namespace BusinessData.ofDataAccessLayer.ofWarehouse.ofDbContext
{
    public class BackUpWarehouseDbContext : DbContext
    {
        private string _connectionstring;
        public BackUpWarehouseDbContext(DbContextOptions<WarehouseDbContext> options)
            : base(options)
        {

        }
        public BackUpWarehouseDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.WarehouseDbConnection; }
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
        public DbSet<DividedTag> DividedTags { get; set; }
        public DbSet<IncomingTag> IncomingTags { get; set; }
        public DbSet<LoadFrame> LoadFrames { get; set; }
        public DbSet<WorkingDesk> WorkingDesks { get; set; }
        public DbSet<DotBarcode> DotBarcodes { get; set; }
    }
}