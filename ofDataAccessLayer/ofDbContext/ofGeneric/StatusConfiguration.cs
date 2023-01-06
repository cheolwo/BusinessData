using BusinessData.ofDataAccessLayer.ofCommon;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration
{
    public class StatusConfiguration<TEntity> : EntityConfiguration<TEntity> where TEntity : Status
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
        }
    }
    public class SStatusConfiguration<TEntity> : StatusConfiguration<TEntity> where TEntity : SStatus
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
        }
    }
    public class MStatusConfiguration<TEntity> : StatusConfiguration<TEntity> where TEntity : MStatus
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
        }
    }
    public class EStatusConfiguration<TEntity> : StatusConfiguration<TEntity> where TEntity : EStatus
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
        }
    }
}