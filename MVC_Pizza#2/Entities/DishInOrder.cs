namespace NeGlovo.Entities;

/// <summary>
/// Блюдо в замовленні
/// </summary>
public class DishInOrder : BaseEntity
{
    /// <summary>
    /// Айді замовлення
    /// </summary>
    public required Guid OrderId { get; set; }
    
    /// <summary>
    /// Айді страви
    /// </summary>
    public required Guid DishId { get; set; }
    
    /// <summary>
    /// Кількість
    /// </summary>
    public required int Amount { get; set; }
    
    /// <summary>
    /// EF nav prop
    /// </summary>
    public Order? Order { get; set; }
    public Dish? Dish { get; set; }
}