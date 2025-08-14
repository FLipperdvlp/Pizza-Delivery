namespace MVC_Pizza.Entities;

public class Pizza
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Ingredients { get; set; }
    public decimal Price { get; set; }
}