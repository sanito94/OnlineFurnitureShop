using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineFurnitureShop.Infrastructure.Data.Models;
using OnlineFurnitureShop.Infrastructure.Data.Models.Seed;

namespace OnlineFurnitureShop.Data
{
    public class OnlineFurnitureShopDbContext : IdentityDbContext
    {
        public OnlineFurnitureShopDbContext(DbContextOptions<OnlineFurnitureShopDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new SubCategoryConfiguration());
            builder.ApplyConfiguration(new ItemConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
        public DbSet<Cart> Carts { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Coupon> Coupons { get; set; } = null!;
        public DbSet<Item> Items { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<SubCategory> SubCategories { get; set; } = null!;
    }
}