using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using MVC_Pizza.Entities;

namespace MVC_Pizza.DataBase;

public class PizzaDBContext : DbContext
{
    public required DbSet<Order> Orders { get; set; }
    public required DbSet<Pizza> Pizzas { get; set; }

    public PizzaDBContext(DbContextOptions<PizzaDBContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pizza>().HasKey(pizza => pizza.Id);
        
        modelBuilder.Entity<Pizza>().HasData(
            new Pizza
            {
                Id = 1,
                Name = "🍅 Margherita Classic",
                Ingredients = "Fresh tomato sauce, mozzarella, basil, olive oil",
                Price = 175
            },
            new Pizza
            {
                Id = 2,
                Name = "🍕 Pepperoni Supreme",
                Ingredients = "Spicy pepperoni, mozzarella, tomato sauce",
                Price = 200
            },
            new Pizza
            {
                Id = 3,
                Name = "🍍 Hawaiian Paradise",
                Ingredients = "Ham, pineapple, mozzarella, tomato sauce",
                Price = 215
            });
        
        modelBuilder.Entity<Order>().ToTable("Order");
        
        modelBuilder.Entity<Order>().HasData(
            new Order
            {
                Id = 1,
                ClientName = "Nikita Andreevich",
                ClientPhoneNumber = "+380951111111",
                IsSelfDelivery = false,
                PizzaId = 3,
                Quantity = 2
            },
            new Order
            {
                Id = 2,
                ClientName = "Rzeczpospolita Polska",
                ClientPhoneNumber = "+48572512856",
                IsSelfDelivery = true,
                PizzaId = 1,
                Quantity = 1939
            });
    }
}