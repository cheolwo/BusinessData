using BusinessData.ofDataAccessLayer.ofCommon;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofDataAccessLayer.ofGroupOrder.ofDbContext
{
    public class BackUpGroupOrderDbContext : DbContext
    {
        private string _connectionstring;
        public BackUpGroupOrderDbContext(DbContextOptions<GroupOrderDbContext> options)
            : base(options)
        {

        }
        public BackUpGroupOrderDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.GroupOrderDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GOCCConfiguration());
            modelBuilder.ApplyConfiguration(new GOCConfiguration());
            modelBuilder.ApplyConfiguration(new SGOConfiguration());
            modelBuilder.ApplyConfiguration(new MGOConfiguration());
            modelBuilder.ApplyConfiguration(new EGOConfiguration());
        }
    }
}
