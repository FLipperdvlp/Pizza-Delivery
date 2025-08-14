using MVC_Pizza.Entities;

namespace MVC_Pizza.Moduls;

public class OrderModel
{
    public IEnumerable<SelectPizzaModel> SelectPizza { get; set; } = [];
    
    public class SelectPizzaModel
    {
        public int Id { get; set; }
        public string Text { get; set; } = null!;

        public SelectPizzaModel(Pizza pizza)
        {
            Id = pizza.Id;
            Text = $"{pizza.Name} - {pizza.Ingredients}";
        }
    }
}