using Microsoft.EntityFrameworkCore;
using WeShopX.Domain.CategoryManagement;
using WeShopX.Domain.CategoryManagement.Entities;
using WeShopX.Domain.MarketingManagement;
using WeShopX.Domain.OrderManagement;
using WeShopX.Domain.OrderManagement.Entities;
using WeShopX.Domain.ProductManagement;
using WeShopX.Domain.ProductManagement.Entities;
using WeShopX.Domain.UserManagement;
using WeShopX.Domain.UserManagement.Entities;
using WeShopX.Domain.VendorManagement;

namespace WeShopX.Infrastructure.Persistence.Context
{
    public class WeShopXDbContext : DbContext
    {
        public WeShopXDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductFeature> ProductFeatures { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<Brand> Brands { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Coupon> Coupons { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
 


            base.OnModelCreating(modelBuilder);
        }
    }
}
