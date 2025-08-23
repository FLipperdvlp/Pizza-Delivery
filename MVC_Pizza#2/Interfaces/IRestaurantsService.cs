using NeGlovo.Entities;

namespace NeGlovo.Interfaces;

public interface IRestaurantsService
{
    // Отримати всі ресторани
    Task<IEnumerable<Restaurant>> GetAllRestaurantsAsync();

    // Отримати ресторан по айді
    Task<Restaurant?> GetRestaurantByIdAsync(Guid id, bool includeDishes = false);
}