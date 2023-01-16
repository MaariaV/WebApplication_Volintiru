using Microsoft.EntityFrameworkCore;
using WebApplication_Volintiru.Models;

namespace WebApplication_Volintiru.Data
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options) :
base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<DeliveryFood> DeliveryFoods { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Food>().ToTable("Food");
            modelBuilder.Entity<Delivery>().ToTable("Delivery");
            modelBuilder.Entity<DeliveryFood>().ToTable("DeliveryFood");
            modelBuilder.Entity<DeliveryFood>()
            .HasKey(c => new { c.FoodID, c.DeliveryID });//configureaza cheia primaracompusa
        }
    }
}
