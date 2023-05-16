using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCCore_1.Models.Entities;

namespace MVCCore_1.Models.DBConfiguration
{
    public class OrderDetailConfiguration:BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasKey(x => new
            {
                x.OrderID,
                x.ProductID,
            });
        }

    }
}
