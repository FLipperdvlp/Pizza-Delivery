using System.ComponentModel.DataAnnotations;

namespace MVC_Pizza.Moduls;

public class CreateOrderRequestModel
{
    [Required, MaxLength(16)]
    public required string Name { get; set; }
    
    [Required, Phone]
    public required string PhoneNumber { get; set; }
    
    [Required, Range(0, int.MaxValue)]
    public required int PizzaId { get; set; }
    
    [Required, Range(0, 32)]
    public required int Quantity { get; set; }
    
    [Required]
    public required bool IsSelfDelivery { get; set; }
}