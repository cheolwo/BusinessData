using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofDataAccessLayer.ofHR.ofDbContext
{
    // 고용계약 DB
    public class BackUpHRDbContext : DbContext
    {
        private string _connectionstring;
        public BackUpHRDbContext(DbContextOptions<HRDbContext> options)
            : base(options)
        {

        }
        public BackUpHRDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.HRDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new HRCenterConfigration());
            builder.ApplyConfiguration(new HREmployeeConfigration());
            builder.ApplyConfiguration(new HRRoleConfigration());
            builder.ApplyConfiguration(new EmployeeRoleConfigration());
            builder.ApplyConfiguration(new HRBusinessPartConfigration());
        }
    }
}