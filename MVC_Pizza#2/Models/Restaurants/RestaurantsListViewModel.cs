using NeGlovo.Entities;

namespace NeGlovo.Models.Restaurants;

public class RestaurantsListViewModel
{
    // Масив ресторанів, що будуть показуватися на сторінці всіх ресторанів
    public IEnumerable<RestaurantModel> Restaurants { get; set; }

    public RestaurantsListViewModel(IEnumerable<Restaurant> restaurants)
    {
        // Масив entities ресторанів конвертуємо в масив моделей
        Restaurants = restaurants.Select(r => new RestaurantModel(r));
    }
    
    

    // Клас описуючий один ресторан, що буде показуватися
    public class RestaurantModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public TimeSpan OpensAt { get; set; }
        public TimeSpan ClosesAt { get; set; }
        public string? ImageUrl { get; set; }

        public RestaurantModel(Restaurant restaurant)
        {
            Id = restaurant.Id;
            Name = restaurant.Name;
            Address = restaurant.Address;
            OpensAt = restaurant.OpensAt;
            ClosesAt = restaurant.ClosesAt;
            ImageUrl = restaurant.ImageUrl;
        }
    }
}