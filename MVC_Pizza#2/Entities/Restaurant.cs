using NeGlovo.Entities.Owned;

namespace NeGlovo.Entities;

/// <summary>
/// Заклад що готує їжу
/// </summary>
public class Restaurant : BaseEntity
{
    /// <summary>
    /// Назва
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Адреса
    /// </summary>
    public required string Address { get; set; }
    
    /// <summary>
    /// Час відкриття
    /// </summary>
    public required TimeSpan OpensAt { get; set; }
    
    /// <summary>
    /// Час закриття
    /// </summary>
    public required TimeSpan ClosesAt { get; set; }
    
    /// <summary>
    /// Картинка
    /// </summary>
    public string? ImageUrl { get; set; }

    /// <summary>
    /// Координати
    /// </summary>
    public Coordinates Coordinates { get; set; } = null!;
    
    /// <summary>
    /// EF reverse nav prop
    /// </summary>
    public ICollection<Order>? Orders { get; set; }
    public ICollection<Dish>? Dishes { get; set; }
}