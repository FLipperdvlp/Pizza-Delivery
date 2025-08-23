using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeGlovo.Entities;

namespace NeGlovo.Database.Configurations;

public class DishInOrderConfiguration : IEntityTypeConfiguration<DishInOrder>
{
    public void Configure(EntityTypeBuilder<DishInOrder> builder)
    {
        builder.HasOne(dio => dio.Dish)
            .WithMany(dish => dish.DishesInOrder)
            .HasForeignKey(dio => dio.DishId);

        builder.HasOne(dio => dio.Order)
            .WithMany(order => order.DishesInOrder)
            .HasForeignKey(dio => dio.OrderId);

        // DishInOrder
        builder.HasData(
            new DishInOrder
            {
                Id = Guid.Parse("aa1b2c3d-4e5f-6a7b-8c9d-0e1f2a3b4c5d"),
                OrderId = Guid.Parse("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                DishId = Guid.Parse("a1b2c3d4-e5f6-7a8b-9c0d-1e2f3a4b5c6d"), // Піца Маргарита
                Amount = 2,
                CreatedAt = DateTime.Parse("2024-01-27 12:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 12:30:00")
            },
            new DishInOrder
            {
                Id = Guid.Parse("bb2c3d4e-5f6a-7b8c-9d0e-1f2a3b4c5d6e"),
                OrderId = Guid.Parse("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                DishId = Guid.Parse("b2c3d4e5-f6a7-8b9c-0d1e-2f3a4b5c6d7e"), // Піца Пепероні
                Amount = 1,
                CreatedAt = DateTime.Parse("2024-01-27 12:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 12:30:00")
            },
            new DishInOrder
            {
                Id = Guid.Parse("cc3d4e5f-6a7b-8c9d-0e1f-2a3b4c5d6e7f"),
                OrderId = Guid.Parse("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"),
                DishId = Guid.Parse("c3d4e5f6-a7b8-9c0d-1e2f-3a4b5c6d7e8f"), // Біг Мак
                Amount = 3,
                CreatedAt = DateTime.Parse("2024-01-27 14:15:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 14:15:00")
            },
            new DishInOrder
            {
                Id = Guid.Parse("dd4e5f6a-7b8c-9d0e-1f2a-3b4c5d6e7f8a"),
                OrderId = Guid.Parse("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"),
                DishId = Guid.Parse("d4e5f6a7-b8c9-0d1e-2f3a-4b5c6d7e8f9a"), // Картопля фрі велика
                Amount = 2,
                CreatedAt = DateTime.Parse("2024-01-27 14:15:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 14:15:00")
            },
            new DishInOrder
            {
                Id = Guid.Parse("ee5f6a7b-8c9d-0e1f-2a3b-4c5d6e7f8a9b"),
                OrderId = Guid.Parse("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"),
                DishId = Guid.Parse("e5f6a7b8-c9d0-1e2f-3a4b-5c6d7e8f9a0b"), // Філадельфія ролл
                Amount = 2,
                CreatedAt = DateTime.Parse("2024-01-27 15:20:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 15:20:00")
            },
            new DishInOrder
            {
                Id = Guid.Parse("ff6a7b8c-9d0e-1f2a-3b4c-5d6e7f8a9b0c"),
                OrderId = Guid.Parse("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"),
                DishId = Guid.Parse("f6a7b8c9-d0e1-2f3a-4b5c-6d7e8f9a0b1c"), // Каліфорнія ролл
                Amount = 1,
                CreatedAt = DateTime.Parse("2024-01-27 15:20:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 15:20:00")
            },
            new DishInOrder
            {
                Id = Guid.Parse("aa7b8c9d-0e1f-2a3b-4c5d-6e7f8a9b0c1d"),
                OrderId = Guid.Parse("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9a"),
                DishId = Guid.Parse("a7b8c9d0-e1f2-3a4b-5c6d-7e8f9a0b1c2d"), // Борщ український з салом
                Amount = 1,
                CreatedAt = DateTime.Parse("2024-01-27 16:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 16:00:00")
            },
            new DishInOrder
            {
                Id = Guid.Parse("bb8c9d0e-1f2a-3b4c-5d6e-7f8a9b0c1d2e"),
                OrderId = Guid.Parse("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9a0b"),
                DishId = Guid.Parse("c9d0e1f2-a3b4-5c6d-7e8f-9a0b1c2d3e4f"), // Баскет Original
                Amount = 2,
                CreatedAt = DateTime.Parse("2024-01-26 18:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-26 18:30:00")
            },
            new DishInOrder
            {
                Id = Guid.Parse("cc9d0e1f-2a3b-4c5d-6e7f-8a9b0c1d2e3f"),
                OrderId = Guid.Parse("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"),
                DishId = Guid.Parse("d0e1f2a3-b4c5-6d7e-8f9a-0b1c2d3e4f5a"), // Хачапурі по-аджарськи
                Amount = 1,
                CreatedAt = DateTime.Parse("2024-01-27 19:45:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 19:45:00")
            },
            new DishInOrder
            {
                Id = Guid.Parse("dd0e1f2a-3b4c-5d6e-7f8a-9b0c1d2e3f4a"),
                OrderId = Guid.Parse("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"),
                DishId = Guid.Parse("e1f2a3b4-c5d6-7e8f-9a0b-1c2d3e4f5a6b"), // Воппер
                Amount = 1,
                CreatedAt = DateTime.Parse("2024-01-27 20:15:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 20:15:00")
            },
            new DishInOrder
            {
                Id = Guid.Parse("ee1f2a3b-4c5d-6e7f-8a9b-0c1d2e3f4a5b"),
                OrderId = Guid.Parse("8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"),
                DishId = Guid.Parse("f2a3b4c5-d6e7-8f9a-0b1c-2d3e4f5a6b7c"), // Котлета по-київськи
                Amount = 2,
                CreatedAt = DateTime.Parse("2024-01-27 21:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 21:00:00")
            },
            new DishInOrder
            {
                Id = Guid.Parse("ff2a3b4c-5d6e-7f8a-9b0c-1d2e3f4a5b6c"),
                OrderId = Guid.Parse("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"),
                DishId = Guid.Parse("a3b4c5d6-e7f8-9a0b-1c2d-3e4f5a6b7c8d"), // Піца Чотири сири
                Amount = 1,
                CreatedAt = DateTime.Parse("2024-01-26 17:20:00"),
                UpdatedAt = DateTime.Parse("2024-01-26 17:20:00")
            });
    }
}