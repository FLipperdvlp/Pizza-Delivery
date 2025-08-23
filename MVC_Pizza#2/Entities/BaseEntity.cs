using System.ComponentModel.DataAnnotations;

namespace NeGlovo.Entities;

public abstract class BaseEntity
{
    /// <summary>
    /// Id
    /// </summary>
    [Key]
    public Guid Id { get; set; }
    
    /// <summary>
    /// Час створення
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    
    /// <summary>
    /// Час останнього оновлення
    /// </summary>
    public DateTime UpdatedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Чи видалено (soft delete)
    /// </summary>
    public bool IsDeleted { get; set; } = false;
}