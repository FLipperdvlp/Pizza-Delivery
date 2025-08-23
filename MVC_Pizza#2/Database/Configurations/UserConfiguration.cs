using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeGlovo.Entities;
using NeGlovo.Enums;

namespace NeGlovo.Database.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        // Робимо телефон унікальним
        builder.HasIndex(u => u.Phone).IsUnique();

        // По замовченню не виконувати запити на видалених користувачів
        builder.HasQueryFilter(u => !u.IsDeleted);

        // Додаємо користувачів
        // Users
        builder.HasData(
            new User
            {
                Id = Guid.Parse("8a5b2c3d-4e5f-6a7b-8c9d-0e1f2a3b4c5d"),
                Phone = "+380501234567",
                PasswordHash = "hashed_password_1",
                Name = "Олександр Петренко",
                Role = UserRole.Client,
                ImageUrl = "https://example.com/images/user1.jpg",
                CreatedAt = DateTime.Parse("2024-01-15 10:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-15 10:30:00")
            },
            new User
            {
                Id = Guid.Parse("9b6c3d4e-5f6a-7b8c-9d0e-1f2a3b4c5d6e"),
                Phone = "+380502345678",
                PasswordHash = "hashed_password_2",
                Name = "Марія Іваненко",
                Role = UserRole.Client,
                ImageUrl = "https://example.com/images/user2.jpg",
                CreatedAt = DateTime.Parse("2024-01-16 14:20:00"),
                UpdatedAt = DateTime.Parse("2024-01-16 14:20:00")
            },
            new User
            {
                Id = Guid.Parse("ac7d4e5f-6a7b-8c9d-0e1f-2a3b4c5d6e7f"),
                Phone = "+380503456789",
                PasswordHash = "hashed_password_3",
                Name = "Дмитро Коваленко",
                Role = UserRole.Courier,
                ImageUrl = "https://example.com/images/user3.jpg",
                CreatedAt = DateTime.Parse("2024-01-17 09:15:00"),
                UpdatedAt = DateTime.Parse("2024-01-17 09:15:00")
            },
            new User
            {
                Id = Guid.Parse("bd8e5f6a-7b8c-9d0e-1f2a-3b4c5d6e7f8a"),
                Phone = "+380504567890",
                PasswordHash = "hashed_password_4",
                Name = "Анна Сидорова",
                Role = UserRole.Client,
                ImageUrl = null,
                CreatedAt = DateTime.Parse("2024-01-18 16:45:00"),
                UpdatedAt = DateTime.Parse("2024-01-18 16:45:00")
            },
            new User
            {
                Id = Guid.Parse("ce9f6a7b-8c9d-0e1f-2a3b-4c5d6e7f8a9b"),
                Phone = "+380505678901",
                PasswordHash = "hashed_password_5",
                Name = "Василь Мельник",
                Role = UserRole.Courier,
                ImageUrl = "https://example.com/images/user5.jpg",
                CreatedAt = DateTime.Parse("2024-01-19 11:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-19 11:30:00")
            },
            new User
            {
                Id = Guid.Parse("dfa0b7c8-9d0e-1f2a-3b4c-5d6e7f8a9b0c"),
                Phone = "+380506789012",
                PasswordHash = "hashed_password_6",
                Name = "Тетяна Бондаренко",
                Role = UserRole.Client,
                ImageUrl = "https://example.com/images/user6.jpg",
                CreatedAt = DateTime.Parse("2024-01-20 13:10:00"),
                UpdatedAt = DateTime.Parse("2024-01-20 13:10:00")
            },
            new User
            {
                Id = Guid.Parse("e0b1c8d9-0e1f-2a3b-4c5d-6e7f8a9b0c1d"),
                Phone = "+380507890123",
                PasswordHash = "hashed_password_7",
                Name = "Ігор Левченко",
                Role = UserRole.Admin,
                ImageUrl = "https://example.com/images/user7.jpg",
                CreatedAt = DateTime.Parse("2024-01-21 08:00:00"),
                UpdatedAt = DateTime.Parse("2024-01-21 08:00:00")
            },
            new User
            {
                Id = Guid.Parse("f1c2d9ea-1f2a-3b4c-5d6e-7f8a9b0c1d2e"),
                Phone = "+380508901234",
                PasswordHash = "hashed_password_8",
                Name = "Світлана Романова",
                Role = UserRole.Client,
                ImageUrl = null,
                CreatedAt = DateTime.Parse("2024-01-22 15:25:00"),
                UpdatedAt = DateTime.Parse("2024-01-22 15:25:00")
            },
            new User
            {
                Id = Guid.Parse("a2d3eafb-2a3b-4c5d-6e7f-8a9b0c1d2e3f"),
                Phone = "+380509012345",
                PasswordHash = "hashed_password_9",
                Name = "Максим Григоренко",
                Role = UserRole.Courier,
                ImageUrl = "https://example.com/images/user9.jpg",
                CreatedAt = DateTime.Parse("2024-01-23 12:40:00"),
                UpdatedAt = DateTime.Parse("2024-01-23 12:40:00")
            },
            new User
            {
                Id = Guid.Parse("b3e4fb0c-3b4c-5d6e-7f8a-9b0c1d2e3f4a"),
                Phone = "+380500123456",
                PasswordHash = "hashed_password_10",
                Name = "Наталія Шевченко",
                Role = UserRole.Client,
                ImageUrl = "https://example.com/images/user10.jpg",
                CreatedAt = DateTime.Parse("2024-01-24 17:55:00"),
                UpdatedAt = DateTime.Parse("2024-01-24 17:55:00")
            },
            new User
            {
                Id = Guid.Parse("c4f50c1d-4c5d-6e7f-8a9b-0c1d2e3f4a5b"),
                Phone = "+380501122334",
                PasswordHash = "hashed_password_11",
                Name = "Сергій Ткаченко",
                Role = UserRole.Courier,
                ImageUrl = "https://example.com/images/user11.jpg",
                CreatedAt = DateTime.Parse("2024-01-25 07:30:00"),
                UpdatedAt = DateTime.Parse("2024-01-25 07:30:00")
            },
            new User
            {
                Id = Guid.Parse("d5061d2e-5d6e-7f8a-9b0c-1d2e3f4a5b6c"),
                Phone = "+380502233445",
                PasswordHash = "hashed_password_12",
                Name = "Оксана Морозова",
                Role = UserRole.Client,
                ImageUrl = null,
                CreatedAt = DateTime.Parse("2024-01-26 19:20:00"),
                UpdatedAt = DateTime.Parse("2024-01-26 19:20:00")
            });
    }
}