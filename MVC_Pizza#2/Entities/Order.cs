using NeGlovo.Entities.Owned;
using NeGlovo.Enums;

namespace NeGlovo.Entities;

/// <summary>
/// Замовлення
/// </summary>
public class Order : BaseEntity
{
    /// <summary>
    /// Id клієнта
    /// </summary>
    public required Guid ClientId { get; set; }
    
    /// <summary>
    /// Айді курьєру
    /// </summary>
    public required Guid CourierId { get; set; }
    
    /// <summary>
    /// Айді ресторану
    /// </summary>
    public required Guid RestaurantId { get; set; }

    /// <summary>
    /// Кординати куди доставляти
    /// </summary>
    public Coordinates DestinationCoordinates { get; set; } = null!;
    
    /// <summary>
    /// Статус замовлення
    /// </summary>
    public required OrderStatus Status { get; set; }
    
    /// <summary>
    /// EF nav prop
    /// </summary>
    public User? Client { get; set; }
    public User? Courier { get; set; }
    public Restaurant? Restaurant { get; set; }
    
    /// <summary>
    /// EF reverse nav prop
    /// </summary>
    public ICollection<DishInOrder>? DishesInOrder { get; set; }
}