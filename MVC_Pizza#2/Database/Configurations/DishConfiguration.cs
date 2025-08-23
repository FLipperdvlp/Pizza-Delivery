using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeGlovo.Entities;

namespace NeGlovo.Database.Configurations;

public class DishConfiguration : IEntityTypeConfiguration<Dish>
{
    public void Configure(EntityTypeBuilder<Dish> builder)
    {
        builder.HasOne(dish => dish.Restaurant)
            .WithMany(restaurant => restaurant.Dishes)
            .HasForeignKey(dish => dish.RestaurantId);

        // Dishes
        builder.HasData(
            new Dish
            {
                Id = Guid.Parse("a1b2c3d4-e5f6-7a8b-9c0d-1e2f3a4b5c6d"),
                RestaurantId = Guid.Parse("f7a1b2c3-d4e5-f6a7-b8c9-d0e1f2a3b4c5"), // Піца Челентано
                Name = "Піца Маргарита",
                Price = 285.50m,
                ImageUrl = "https://example.com/images/dish1.jpg",
                IsAvailable = true,
                CreatedAt = DateTime.Parse("2024-01-10 10:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-10 10:00:00")
            },
            new Dish
            {
                Id = Guid.Parse("b2c3d4e5-f6a7-8b9c-0d1e-2f3a4b5c6d7e"),
                RestaurantId = Guid.Parse("f7a1b2c3-d4e5-f6a7-b8c9-d0e1f2a3b4c5"), // Піца Челентано
                Name = "Піца Пепероні",
                Price = 320.00m,
                ImageUrl = "https://example.com/images/dish2.jpg",
                IsAvailable = true,
                CreatedAt = DateTime.Parse("2024-01-10 10:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-10 10:30:00")
            },
            new Dish
            {
                Id = Guid.Parse("c3d4e5f6-a7b8-9c0d-1e2f-3a4b5c6d7e8f"),
                RestaurantId = Guid.Parse("e8b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), // McDonald's
                Name = "Біг Мак",
                Price = 89.00m,
                ImageUrl = "https://example.com/images/dish3.jpg",
                IsAvailable = true,
                CreatedAt = DateTime.Parse("2024-01-11 09:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-11 09:00:00")
            },
            new Dish
            {
                Id = Guid.Parse("d4e5f6a7-b8c9-0d1e-2f3a-4b5c6d7e8f9a"),
                RestaurantId = Guid.Parse("e8b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), // McDonald's
                Name = "Картопля фрі велика",
                Price = 45.00m,
                ImageUrl = "https://example.com/images/dish4.jpg",
                IsAvailable = true,
                CreatedAt = DateTime.Parse("2024-01-11 09:15:00"),
                UpdatedAt = DateTime.Parse("2024-01-11 09:15:00")
            },
            new Dish
            {
                Id = Guid.Parse("e5f6a7b8-c9d0-1e2f-3a4b-5c6d7e8f9a0b"),
                RestaurantId = Guid.Parse("d9c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), // Сушия
                Name = "Філадельфія ролл",
                Price = 195.00m,
                ImageUrl = "https://example.com/images/dish5.jpg",
                IsAvailable = true,
                CreatedAt = DateTime.Parse("2024-01-12 11:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-12 11:00:00")
            },
            new Dish
            {
                Id = Guid.Parse("f6a7b8c9-d0e1-2f3a-4b5c-6d7e8f9a0b1c"),
                RestaurantId = Guid.Parse("d9c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), // Сушия
                Name = "Каліфорнія ролл",
                Price = 165.00m,
                ImageUrl = null,
                IsAvailable = true,
                CreatedAt = DateTime.Parse("2024-01-12 11:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-12 11:30:00")
            },
            new Dish
            {
                Id = Guid.Parse("a7b8c9d0-e1f2-3a4b-5c6d-7e8f9a0b1c2d"),
                RestaurantId = Guid.Parse("cad4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e7f8"), // Борщ & Сало
                Name = "Борщ український з салом",
                Price = 85.00m,
                ImageUrl = "https://example.com/images/dish7.jpg",
                IsAvailable = true,
                CreatedAt = DateTime.Parse("2024-01-13 12:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-13 12:00:00")
            },
            new Dish
            {
                Id = Guid.Parse("b8c9d0e1-f2a3-4b5c-6d7e-8f9a0b1c2d3e"),
                RestaurantId = Guid.Parse("cad4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e7f8"), // Борщ & Сало
                Name = "Вареники з картоплею",
                Price = 75.00m,
                ImageUrl = "https://example.com/images/dish8.jpg",
                IsAvailable = false,
                CreatedAt = DateTime.Parse("2024-01-13 12:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-13 12:30:00")
            },
            new Dish
            {
                Id = Guid.Parse("c9d0e1f2-a3b4-5c6d-7e8f-9a0b1c2d3e4f"),
                RestaurantId = Guid.Parse("bbe5f6a7-b8c9-d0e1-f2a3-b4c5d6e7f8a9"), // KFC
                Name = "Баскет Original",
                Price = 149.00m,
                ImageUrl = "https://example.com/images/dish9.jpg",
                IsAvailable = true,
                CreatedAt = DateTime.Parse("2024-01-14 10:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-14 10:00:00")
            },
            new Dish
            {
                Id = Guid.Parse("d0e1f2a3-b4c5-6d7e-8f9a-0b1c2d3e4f5a"),
                RestaurantId = Guid.Parse("acf6a7b8-c9d0-e1f2-a3b4-c5d6e7f8a9ba"), // Мама Манана
                Name = "Хачапурі по-аджарськи",
                Price = 175.00m,
                ImageUrl = "https://example.com/images/dish10.jpg",
                IsAvailable = true,
                CreatedAt = DateTime.Parse("2024-01-15 14:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-15 14:30:00")
            },
            new Dish
            {
                Id = Guid.Parse("e1f2a3b4-c5d6-7e8f-9a0b-1c2d3e4f5a6b"),
                RestaurantId = Guid.Parse("9d07b8c9-d0e1-f2a3-b4c5-d6e7f8a9bacb"), // Burger King
                Name = "Воппер",
                Price = 95.50m,
                ImageUrl = "https://example.com/images/dish11.jpg",
                IsAvailable = true,
                CreatedAt = DateTime.Parse("2024-01-16 09:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-16 09:00:00")
            },
            new Dish
            {
                Id = Guid.Parse("f2a3b4c5-d6e7-8f9a-0b1c-2d3e4f5a6b7c"),
                RestaurantId = Guid.Parse("8e18c9da-e1f2-a3b4-c5d6-e7f8a9bacbdc"), // Пузата Хата
                Name = "Котлета по-київськи",
                Price = 125.00m,
                ImageUrl = null,
                IsAvailable = true,
                CreatedAt = DateTime.Parse("2024-01-17 08:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-17 08:00:00")
            },
            new Dish
            {
                Id = Guid.Parse("a3b4c5d6-e7f8-9a0b-1c2d-3e4f5a6b7c8d"),
                RestaurantId = Guid.Parse("7f29daeb-f2a3-b4c5-d6e7-f8a9bacbdced"), // Domino's Pizza
                Name = "Піца Чотири сири",
                Price = 295.00m,
                ImageUrl = "https://example.com/images/dish13.jpg",
                IsAvailable = true,
                CreatedAt = DateTime.Parse("2024-01-18 11:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-18 11:30:00")
            });
    }
}