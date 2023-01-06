using BusinessData.ofDataAccessLayer.ofCommon;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessData.ofDataAccessLayer.ofGeneric.ofTypeConfiguration
{
    public enum ConstraintLength { Id = 30 , Name = 300, Barcode = 30, Address = 30}
    
    public class EntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : Entity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(c => c.ChangedUsers).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<ChangeUser>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 new ValueComparer<List<ChangeUser>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));

            builder.Property(c => c.ImageofInfos).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<ImageofInfo>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 new ValueComparer<List<ImageofInfo>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));

            builder.Property(c => c.Docs).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<Doc>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 new ValueComparer<List<Doc>>((c1, c2) => c1.SequenceEqual(c2),
                 c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
            c => c.ToList()));
        }
    }
}
/*
 * A typical value conversion on a list property might convert the list to and from JSON:

modelBuilder
    .Entity<EntityType>()
    .Property(e => e.MyProperty)
    .HasConversion(
        v => JsonSerializer.Serialize(v, null),
        v => JsonSerializer.Deserialize<List<int>>(v, null));
This then requires setting a ValueComparer<T> on the property to force EF Core use correct comparisons with this conversion:

var valueComparer = new ValueComparer<List<int>>(
    (c1, c2) => c1.SequenceEqual(c2),
    c => c.Aggregate(0, (a, v) => HashCode.Combine(a, v.GetHashCode())),
    c => c.ToList());

modelBuilder
    .Entity<EntityType>()
    .Property(e => e.MyProperty)
    .Metadata
    .SetValueComparer(valueComparer);
 */