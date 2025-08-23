using Microsoft.EntityFrameworkCore;
using NeGlovo.Database.Configurations;
using NeGlovo.Entities;

namespace NeGlovo.Database;

public class AppDbContext : DbContext
{
    public required DbSet<User> Users { get; set; }
    public required DbSet<Dish> Dishes { get; set; }
    public required DbSet<Order> Orders { get; set; }
    public required DbSet<Restaurant> Restaurants { get; set; }
    public required DbSet<DishInOrder> DishesInOrders { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source = neglovo.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Застосувати нашу конфігурацію сутності user
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new DishConfiguration());
        modelBuilder.ApplyConfiguration(new DishInOrderConfiguration());
        modelBuilder.ApplyConfiguration(new RestaurantConfiguration());
    }
}