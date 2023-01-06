using BusinessData.ofDataAccessLayer.ofCommon;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration
{
    public class CommodityConfiguration<TEntity> : EntityConfiguration<TEntity> where TEntity : Commodity
    {
        public override void Configure(EntityTypeBuilder<TEntity> builder)
        {
            base.Configure(builder);
            builder.Property(c => c.Name).HasMaxLength((int)ConstraintLength.Name);
            builder.Property(c => c.Barcode).HasMaxLength((int)ConstraintLength.Barcode);
        }
    }
}