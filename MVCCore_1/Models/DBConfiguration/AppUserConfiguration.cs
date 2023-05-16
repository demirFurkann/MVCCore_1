using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCCore_1.Models.Entities;

namespace MVCCore_1.Models.DBConfiguration
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);

            builder.HasOne(x => x.AppUserProfile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.ID);
        }
    }
}
