using Microsoft.EntityFrameworkCore;
using System.Reflection;
using E_commerce.Configrations;
using E_commerce;
namespace Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
              => optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;DataBase=E-Commerce;Trusted_Connection=True;TrustServerCertificate=True");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedData(modelBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        private void SeedData(ModelBuilder modelBuilder)
        {
            // You can add initial admin user, categories, etc. here
            // Example:
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserID = 1,
                    Username = "admin",
                    Password = "hashed_password_here", // You should hash this
                    Email = "admin@ecommerce.com",
                    FirstName = "Admin",
                    LastName = "User",
                    Role = UserRole.Admin,
                    IsActive = true,

                }
            );
        }
    }
}
