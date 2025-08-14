namespace MVC_Pizza.Entities;

public class Order
{
    public int Id { get; set; }
    
    public string? ClientName { get; set; }
    public string? ClientPhoneNumber { get; set; }
    
    public int PizzaId { get; set; }
    public int Quantity { get; set; }
    
    public bool IsSelfDelivery { get; set; }
    
    public Pizza? Pizza { get; set; }
}