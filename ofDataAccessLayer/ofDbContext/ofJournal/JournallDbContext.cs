using System.Collections.Generic;
using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration;
using BusinessData.ofDataAccessLayer.ofJournal.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace BusinessData.ofDataAccessLayer.ofJournal
{
    public class JournalDbContext : DbContext
    {
        private string _connectionstring;
        public JournalDbContext(DbContextOptions<JournalDbContext> options)
            :base(options)
        {

        }
        public JournalDbContext(string connectionstring)
        {
            _connectionstring = connectionstring;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(_connectionstring is null) { _connectionstring = DevelopmentDbConnetionString.JournalDbConnection; }
            optionsBuilder.UseSqlServer(_connectionstring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JournalCenterConfiguration());
            modelBuilder.ApplyConfiguration(new JCommodityConfiguration());
        }
    }
    public class UserSettingJournalConfiguration : EntityConfiguration<UserSettingJournal>
    {
        public override void Configure(EntityTypeBuilder<UserSettingJournal> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Debits).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Debit>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            builder.Property(c => c.Credits).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Credit>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
        }
    }
    public class JCommodityConfiguration : EntityConfiguration<JCommodity>
    {
        public override void Configure(EntityTypeBuilder<JCommodity> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Journals).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Journal>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            builder.ToTable("JCommodity");
        }
    }
    public class JournalCenterConfiguration : CenterConfiguration<JournalCenter>
    {
        public override void Configure(EntityTypeBuilder<JournalCenter> builder)
        {
            base.Configure(builder);
            builder.ToTable("JournalCenter");
        }
    }
    public class JournalConfiguration : EntityConfiguration<Journal> 
    {
        public override void Configure(EntityTypeBuilder<Journal> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Debits).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Debit>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            builder.Property(c => c.Credits).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Credit>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            
        }
    }
}

