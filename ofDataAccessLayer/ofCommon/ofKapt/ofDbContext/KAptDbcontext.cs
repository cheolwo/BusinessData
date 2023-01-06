using BusinessData.ofCommon.ofKapt;
using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofDataAccessLayer.ofCommon.ofKApt.ofDbContext
{
    public class KAptDbContext : DbContext
    {
        private string _connectionstring;
        public KAptDbContext(DbContextOptions<KAptDbContext> options)
            : base(options)
        {

        }
        public KAptDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            if(_connectionstring is null) { _connectionstring = DbConnectionString.KAptDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KAptAPIInfoConfiguration());
        }
    }
    public class KAptAPIInfoConfiguration : EntityConfiguration<KAptBasicInfo>
    {
        public override void Configure(EntityTypeBuilder<KAptBasicInfo> builder)
        {
            base.Configure(builder);
            builder.Ignore(c => c.ChangedUsers);
            builder.Ignore(c => c.CreateTime);
            builder.Ignore(c => c.UserId);
            builder.Ignore(c => c.Docs);
        }
    }
}