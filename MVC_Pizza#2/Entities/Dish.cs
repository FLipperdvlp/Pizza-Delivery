namespace NeGlovo.Entities;

/// <summary>
/// Блюдо в меню
/// </summary>
public class Dish : BaseEntity
{
    /// <summary>
    /// Id ресторану
    /// </summary>
    public required Guid RestaurantId { get; set; }
    
    /// <summary>
    /// Назва блюда
    /// </summary>
    public required string Name { get; set; }
    
    /// <summary>
    /// Ціна
    /// </summary>
    public required decimal Price { get; set; }
    
    /// <summary>
    /// Картинка
    /// </summary>
    public string? ImageUrl { get; set; }
    
    /// <summary>
    /// Чи доступно
    /// </summary>
    public bool IsAvailable { get; set; }
    
    /// <summary>
    /// EF nav property
    /// </summary>
    public Restaurant? Restaurant { get; set; }
    
    /// <summary>
    /// EF reverse nav prop
    /// </summary>
    public ICollection<DishInOrder>? DishesInOrder { get; set; }
}