using Microsoft.AspNetCore.Mvc;
using NeGlovo.Enums;

namespace NeGlovo.Entities;

/// <summary>
/// Людина в нашій системі (клієнт/кур'єр/адмін)
/// </summary>
public class User : BaseEntity
{
    /// <summary>
    /// Номер телефону
    /// </summary>
    public required string Phone { get; set; }
    
    /// <summary>
    /// Хеш паролю
    /// </summary>
    public required string PasswordHash { get; set; } 
    
    /// <summary>
    /// Ім'я
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Клієнт/кур'єр/адмін
    /// </summary>
    public required UserRole Role { get; set; }
    
    /// <summary>
    /// Посилання на картинку
    /// </summary>
    public string? ImageUrl { get; set; }
    
    /// <summary>
    /// EF reverse nav prop
    /// </summary>
    public ICollection<Order>? OrdersAsClient { get; set; }
    public ICollection<Order>? OrdersAsCourier { get; set; }
}