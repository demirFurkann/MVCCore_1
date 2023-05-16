using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCCore_1.Models.Entities;

namespace MVCCore_1.Models.DBConfiguration
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreatedDate).HasColumnName("Varoluşsal Problemler");
        }
    }
}
