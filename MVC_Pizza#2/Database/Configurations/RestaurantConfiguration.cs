using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeGlovo.Entities;
using NeGlovo.Entities.Owned;

namespace NeGlovo.Database.Configurations;

public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
{
    public void Configure(EntityTypeBuilder<Restaurant> builder)
    {
        // Свойство Coordinates просто розкласти на 2 стовпчики
        builder.OwnsOne(restaurant => restaurant.Coordinates, oc =>
        {
            oc.Property(c => c.Latitude).HasColumnName("Latitude");
            oc.Property(c => c.Longitude).HasColumnName("Longitude");
        });

        // Restaurants
        builder.HasData(
            new Restaurant
            {
                Id = Guid.Parse("f7a1b2c3-d4e5-f6a7-b8c9-d0e1f2a3b4c5"),
                Name = "Піца Челентано",
                Address = "вул. Хрещатик, 15, Київ",
                OpensAt = TimeSpan.Parse("10:00:00"),
                ClosesAt = TimeSpan.Parse("23:00:00"),
                ImageUrl = "https://example.com/images/restaurant1.jpg",
                CreatedAt = DateTime.Parse("2024-01-10 09:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-10 09:00:00")
            },
            new Restaurant
            {
                Id = Guid.Parse("e8b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"),
                Name = "McDonald's",
                Address = "просп. Перемоги, 42, Київ",
                OpensAt = TimeSpan.Parse("06:00:00"),
                ClosesAt = TimeSpan.Parse("02:00:00"),
                ImageUrl = "https://example.com/images/restaurant2.jpg",
                CreatedAt = DateTime.Parse("2024-01-11 08:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-11 08:30:00")
            },
            new Restaurant
            {
                Id = Guid.Parse("d9c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"),
                Name = "Сушия",
                Address = "вул. Саксаганського, 22, Київ",
                OpensAt = TimeSpan.Parse("11:00:00"),
                ClosesAt = TimeSpan.Parse("22:30:00"),
                ImageUrl = "https://example.com/images/restaurant3.jpg",
                CreatedAt = DateTime.Parse("2024-01-12 10:15:00"),
                UpdatedAt = DateTime.Parse("2024-01-12 10:15:00")
            },
            new Restaurant
            {
                Id = Guid.Parse("cad4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e7f8"),
                Name = "Борщ & Сало",
                Address = "вул. Володимирська, 8, Київ",
                OpensAt = TimeSpan.Parse("08:00:00"),
                ClosesAt = TimeSpan.Parse("21:00:00"),
                ImageUrl = null,
                CreatedAt = DateTime.Parse("2024-01-13 11:45:00"),
                UpdatedAt = DateTime.Parse("2024-01-13 11:45:00")
            },
            new Restaurant
            {
                Id = Guid.Parse("bbe5f6a7-b8c9-d0e1-f2a3-b4c5d6e7f8a9"),
                Name = "KFC",
                Address = "вул. Велика Васильківська, 72, Київ",
                OpensAt = TimeSpan.Parse("09:00:00"),
                ClosesAt = TimeSpan.Parse("23:30:00"),
                ImageUrl = "https://example.com/images/restaurant5.jpg",
                CreatedAt = DateTime.Parse("2024-01-14 09:20:00"),
                UpdatedAt = DateTime.Parse("2024-01-14 09:20:00")
            },
            new Restaurant
            {
                Id = Guid.Parse("acf6a7b8-c9d0-e1f2-a3b4-c5d6e7f8a9ba"),
                Name = "Мама Манана",
                Address = "вул. Інститутська, 5, Київ",
                OpensAt = TimeSpan.Parse("12:00:00"),
                ClosesAt = TimeSpan.Parse("01:00:00"),
                ImageUrl = "https://example.com/images/restaurant6.jpg",
                CreatedAt = DateTime.Parse("2024-01-15 14:10:00"),
                UpdatedAt = DateTime.Parse("2024-01-15 14:10:00")
            },
            new Restaurant
            {
                Id = Guid.Parse("9d07b8c9-d0e1-f2a3-b4c5-d6e7f8a9bacb"),
                Name = "Burger King",
                Address = "просп. Оболонський, 1Б, Київ",
                OpensAt = TimeSpan.Parse("07:00:00"),
                ClosesAt = TimeSpan.Parse("24:00:00"),
                ImageUrl = "https://example.com/images/restaurant7.jpg",
                CreatedAt = DateTime.Parse("2024-01-16 08:45:00"),
                UpdatedAt = DateTime.Parse("2024-01-16 08:45:00")
            },
            new Restaurant
            {
                Id = Guid.Parse("8e18c9da-e1f2-a3b4-c5d6-e7f8a9bacbdc"),
                Name = "Пузата Хата",
                Address = "вул. Прорізна, 18/1, Київ",
                OpensAt = TimeSpan.Parse("08:00:00"),
                ClosesAt = TimeSpan.Parse("22:00:00"),
                ImageUrl = "https://example.com/images/restaurant8.jpg",
                CreatedAt = DateTime.Parse("2024-01-17 07:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-17 07:30:00")
            },
            new Restaurant
            {
                Id = Guid.Parse("7f29daeb-f2a3-b4c5-d6e7-f8a9bacbdced"),
                Name = "Domino's Pizza",
                Address = "вул. Льва Толстого, 25, Київ",
                OpensAt = TimeSpan.Parse("10:30:00"),
                ClosesAt = TimeSpan.Parse("23:30:00"),
                ImageUrl = "https://example.com/images/restaurant9.jpg",
                CreatedAt = DateTime.Parse("2024-01-18 11:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-18 11:00:00")
            },
            new Restaurant
            {
                Id = Guid.Parse("603aebfc-a3b4-c5d6-e7f8-a9bacbdcedfe"),
                Name = "Франс.уа",
                Address = "вул. Городецького, 15А, Київ",
                OpensAt = TimeSpan.Parse("08:30:00"),
                ClosesAt = TimeSpan.Parse("22:30:00"),
                ImageUrl = "https://example.com/images/restaurant10.jpg",
                CreatedAt = DateTime.Parse("2024-01-19 10:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-19 10:30:00")
            },
            new Restaurant
            {
                Id = Guid.Parse("514bfc0d-b4c5-d6e7-f8a9-bacbdcedfe0f"),
                Name = "Козырная карта",
                Address = "вул. Шота Руставелі, 44, Київ",
                OpensAt = TimeSpan.Parse("11:30:00"),
                ClosesAt = TimeSpan.Parse("02:30:00"),
                ImageUrl = null,
                CreatedAt = DateTime.Parse("2024-01-20 13:15:00"),
                UpdatedAt = DateTime.Parse("2024-01-20 13:15:00")
            });
        
        builder.OwnsOne(r => r.Coordinates).HasData(
            new { RestaurantId = Guid.Parse("f7a1b2c3-d4e5-f6a7-b8c9-d0e1f2a3b4c5"), Latitude = 50.4501m, Longitude = 30.5234m },
            new { RestaurantId = Guid.Parse("e8b2c3d4-e5f6-a7b8-c9d0-e1f2a3b4c5d6"), Latitude = 50.4547m, Longitude = 30.5238m },
            new { RestaurantId = Guid.Parse("d9c3d4e5-f6a7-b8c9-d0e1-f2a3b4c5d6e7"), Latitude = 50.4392m, Longitude = 30.5205m },
            new { RestaurantId = Guid.Parse("cad4e5f6-a7b8-c9d0-e1f2-a3b4c5d6e7f8"), Latitude = 50.4515m, Longitude = 30.5272m },
            new { RestaurantId = Guid.Parse("bbe5f6a7-b8c9-d0e1-f2a3-b4c5d6e7f8a9"), Latitude = 50.4336m, Longitude = 30.5267m },
            new { RestaurantId = Guid.Parse("acf6a7b8-c9d0-e1f2-a3b4-c5d6e7f8a9ba"), Latitude = 50.4475m, Longitude = 30.5236m },
            new { RestaurantId = Guid.Parse("9d07b8c9-d0e1-f2a3-b4c5-d6e7f8a9bacb"), Latitude = 50.5118m, Longitude = 30.4982m },
            new { RestaurantId = Guid.Parse("8e18c9da-e1f2-a3b4-c5d6-e7f8a9bacbdc"), Latitude = 50.4462m, Longitude = 30.5203m },
            new { RestaurantId = Guid.Parse("7f29daeb-f2a3-b4c5-d6e7-f8a9bacbdced"), Latitude = 50.4338m, Longitude = 30.5191m },
            new { RestaurantId = Guid.Parse("603aebfc-a3b4-c5d6-e7f8-a9bacbdcedfe"), Latitude = 50.4433m, Longitude = 30.5178m },
            new { RestaurantId = Guid.Parse("514bfc0d-b4c5-d6e7-f8a9-bacbdcedfe0f"), Latitude = 50.4298m, Longitude = 30.5254m }
        );

    }
}