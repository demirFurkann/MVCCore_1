using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCCore_1.Models.Entities;

namespace MVCCore_1.Models.DBConfiguration
{
    public class ProductConfiguration:BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.UnitPrice).HasColumnType("money");
        }
    }
}
