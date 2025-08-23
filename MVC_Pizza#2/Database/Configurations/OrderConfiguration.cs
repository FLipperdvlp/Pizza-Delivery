using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeGlovo.Entities;
using NeGlovo.Entities.Owned;
using NeGlovo.Enums;

namespace NeGlovo.Database.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        // Зв'язок замовлення > user (client)
        builder.HasOne(order => order.Client)
            .WithMany(user => user.OrdersAsClient)
            .HasForeignKey(order => order.ClientId)
            .OnDelete(DeleteBehavior.Restrict);

        // Зв'язок замовлення > user (courier)
        builder.HasOne(order => order.Courier)
            .WithMany(user => user.OrdersAsCourier)
            .HasForeignKey(order => order.CourierId)
            .OnDelete(DeleteBehavior.Cascade);

        // Зв'язок замовлення > ресторан
        builder.HasOne(order => order.Restaurant)
            .WithMany(restaurant => restaurant.Orders)
            .HasForeignKey(order => order.RestaurantId)
            .OnDelete(DeleteBehavior.Restrict);

        // Свойство Coordinates просто розкласти на 2 стовпчики
        builder.OwnsOne(order => order.DestinationCoordinates, oc =>
        {
            oc.Property(c => c.Latitude).HasColumnName("Latitude");
            oc.Property(c => c.Longitude).HasColumnName("Longitude");
        });

        // Заповнення даних
        // Orders
        // Orders
        builder.HasData(
            new Order
            {
                Id = Guid.Parse("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                ClientId = Guid.Parse("8a5b2c3d-4e5f-6a7b-8c9d-0e1f2a3b4c5d"),
                CourierId = Guid.Parse("ac7d4e5f-6a7b-8c9d-0e1f-2a3b4c5d6e7f"),
                RestaurantId = Guid.Parse("f7a1b2c3-d4e5-f6a7-b8c9-d0e1f2a3b4c5"),
                Status = OrderStatus.Done,
                CreatedAt = DateTime.Parse("2024-01-27 12:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 13:45:00")
            },
            new Order
            {
                Id = Guid.Parse("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"),
                ClientId = Guid.Parse("9b6c3d4e-5f6a-7b8c-9d0e-1f2a3b4c5d6e"),
                CourierId = Guid.Parse("ce9f6a7b-8c9d-0e1f-2a3b-4c5d6e7f8a9b"),
                RestaurantId = Guid.Parse("e8b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"),
                Status = OrderStatus.Delivering,
                CreatedAt = DateTime.Parse("2024-01-27 14:15:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 14:30:00")
            },
            new Order
            {
                Id = Guid.Parse("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"),
                ClientId = Guid.Parse("bd8e5f6a-7b8c-9d0e-1f2a-3b4c5d6e7f8a"),
                CourierId = Guid.Parse("a2d3eafb-2a3b-4c5d-6e7f-8a9b0c1d2e3f"),
                RestaurantId = Guid.Parse("d9c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"),
                Status = OrderStatus.Cooking,
                CreatedAt = DateTime.Parse("2024-01-27 15:20:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 15:35:00")
            },
            new Order
            {
                Id = Guid.Parse("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9a"),
                ClientId = Guid.Parse("dfa0b7c8-9d0e-1f2a-3b4c-5d6e7f8a9b0c"),
                CourierId = Guid.Parse("c4f50c1d-4c5d-6e7f-8a9b-0c1d2e3f4a5b"),
                RestaurantId = Guid.Parse("cad4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e7f8"),
                Status = OrderStatus.Accepted,
                CreatedAt = DateTime.Parse("2024-01-27 16:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 16:00:00")
            },
            new Order
            {
                Id = Guid.Parse("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9a0b"),
                ClientId = Guid.Parse("f1c2d9ea-1f2a-3b4c-5d6e-7f8a9b0c1d2e"),
                CourierId = Guid.Parse("ac7d4e5f-6a7b-8c9d-0e1f-2a3b4c5d6e7f"),
                RestaurantId = Guid.Parse("bbe5f6a7-b8c9-d0e1-f2a3-b4c5d6e7f8a9"),
                Status = OrderStatus.Done,
                CreatedAt = DateTime.Parse("2024-01-26 18:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-26 19:15:00")
            },
            new Order
            {
                Id = Guid.Parse("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"),
                ClientId = Guid.Parse("b3e4fb0c-3b4c-5d6e-7f8a-9b0c1d2e3f4a"),
                CourierId = Guid.Parse("ce9f6a7b-8c9d-0e1f-2a3b-4c5d6e7f8a9b"),
                RestaurantId = Guid.Parse("acf6a7b8-c9d0-e1f2-a3b4-c5d6e7f8a9ba"),
                Status = OrderStatus.Delivering,
                CreatedAt = DateTime.Parse("2024-01-27 19:45:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 20:10:00")
            },
            new Order
            {
                Id = Guid.Parse("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"),
                ClientId = Guid.Parse("d5061d2e-5d6e-7f8a-9b0c-1d2e3f4a5b6c"),
                CourierId = Guid.Parse("a2d3eafb-2a3b-4c5d-6e7f-8a9b0c1d2e3f"),
                RestaurantId = Guid.Parse("9d07b8c9-d0e1-f2a3-b4c5-d6e7f8a9bacb"),
                Status = OrderStatus.Cooking,
                CreatedAt = DateTime.Parse("2024-01-27 20:15:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 20:30:00")
            },
            new Order
            {
                Id = Guid.Parse("8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"),
                ClientId = Guid.Parse("8a5b2c3d-4e5f-6a7b-8c9d-0e1f2a3b4c5d"),
                CourierId = Guid.Parse("c4f50c1d-4c5d-6e7f-8a9b-0c1d2e3f4a5b"),
                RestaurantId = Guid.Parse("8e18c9da-e1f2-a3b4-c5d6-e7f8a9bacbdc"),
                Status = OrderStatus.Accepted,
                CreatedAt = DateTime.Parse("2024-01-27 21:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 21:00:00")
            },
            new Order
            {
                Id = Guid.Parse("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"),
                ClientId = Guid.Parse("9b6c3d4e-5f6a-7b8c-9d0e-1f2a3b4c5d6e"),
                CourierId = Guid.Parse("ac7d4e5f-6a7b-8c9d-0e1f-2a3b4c5d6e7f"),
                RestaurantId = Guid.Parse("7f29daeb-f2a3-b4c5-d6e7-f8a9bacbdced"),
                Status = OrderStatus.Done,
                CreatedAt = DateTime.Parse("2024-01-26 17:20:00"),
                UpdatedAt = DateTime.Parse("2024-01-26 18:05:00")
            },
            new Order
            {
                Id = Guid.Parse("0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"),
                ClientId = Guid.Parse("bd8e5f6a-7b8c-9d0e-1f2a-3b4c5d6e7f8a"),
                CourierId = Guid.Parse("ce9f6a7b-8c9d-0e1f-2a3b-4c5d6e7f8a9b"),
                RestaurantId = Guid.Parse("603aebfc-a3b4-c5d6-e7f8-a9bacbdcedfe"),
                Status = OrderStatus.Cooking,
                CreatedAt = DateTime.Parse("2024-01-27 22:10:00"),
                UpdatedAt = DateTime.Parse("2024-01-27 22:25:00")
            }
        );

// DestinationCoordinates (Owned)
        builder.OwnsOne(o => o.DestinationCoordinates).HasData(
            new
            {
                OrderId = Guid.Parse("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"), Latitude = 50.4501m, Longitude = 30.5300m
            },
            new
            {
                OrderId = Guid.Parse("2b3c4d5e-6f7a-8b9c-0d1e-2f3a4b5c6d7e"), Latitude = 50.4550m, Longitude = 30.5280m
            },
            new
            {
                OrderId = Guid.Parse("3c4d5e6f-7a8b-9c0d-1e2f-3a4b5c6d7e8f"), Latitude = 50.4400m, Longitude = 30.5150m
            },
            new
            {
                OrderId = Guid.Parse("4d5e6f7a-8b9c-0d1e-2f3a-4b5c6d7e8f9a"), Latitude = 50.4520m, Longitude = 30.5290m
            },
            new
            {
                OrderId = Guid.Parse("5e6f7a8b-9c0d-1e2f-3a4b-5c6d7e8f9a0b"), Latitude = 50.4340m, Longitude = 30.5280m
            },
            new
            {
                OrderId = Guid.Parse("6f7a8b9c-0d1e-2f3a-4b5c-6d7e8f9a0b1c"), Latitude = 50.4480m, Longitude = 30.5250m
            },
            new
            {
                OrderId = Guid.Parse("7a8b9c0d-1e2f-3a4b-5c6d-7e8f9a0b1c2d"), Latitude = 50.5120m, Longitude = 30.5000m
            },
            new
            {
                OrderId = Guid.Parse("8b9c0d1e-2f3a-4b5c-6d7e-8f9a0b1c2d3e"), Latitude = 50.4470m, Longitude = 30.5210m
            },
            new
            {
                OrderId = Guid.Parse("9c0d1e2f-3a4b-5c6d-7e8f-9a0b1c2d3e4f"), Latitude = 50.4350m, Longitude = 30.5200m
            },
            new
            {
                OrderId = Guid.Parse("0d1e2f3a-4b5c-6d7e-8f9a-0b1c2d3e4f5a"), Latitude = 50.4440m, Longitude = 30.5190m
            }
        );
    }
}