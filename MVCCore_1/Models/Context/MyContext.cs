using Microsoft.EntityFrameworkCore;
using MVCCore_1.Models.DBConfiguration;
using MVCCore_1.Models.Entities;

namespace MVCCore_1.Models.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserProfileConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
