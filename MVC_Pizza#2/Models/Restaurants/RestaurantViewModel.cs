using NeGlovo.Entities;

namespace NeGlovo.Models.Restaurants;

public class RestaurantViewModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public TimeSpan OpensAt { get; set; }
    public TimeSpan ClosesAt { get; set; }
    public string? ImageUrl { get; set; }
    public IEnumerable<DishModel> Dishes { get; set; }

    public RestaurantViewModel(Restaurant restaurant)
    {
        Id = restaurant.Id;
        Name = restaurant.Name;
        Address = restaurant.Address;
        OpensAt = restaurant.OpensAt;
        ClosesAt = restaurant.ClosesAt;
        ImageUrl = restaurant.ImageUrl;
        Dishes = restaurant.Dishes!.Select(d => new DishModel(d));
    }
    
    // Клас, описуючий модель однієї страви на сторінці з рестораном
    public class DishModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public bool IsAvailable { get; set; }

        public DishModel(Dish dish)
        {
            Id = dish.Id;
            Name = dish.Name;
            Price = dish.Price;
            ImageUrl = dish.ImageUrl;
            IsAvailable = dish.IsAvailable;
        }
    }
}