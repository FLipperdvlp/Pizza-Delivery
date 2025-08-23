using Microsoft.EntityFrameworkCore;
using NeGlovo.Database;
using NeGlovo.Entities;
using NeGlovo.Interfaces;

namespace NeGlovo.Services;

public class RestaurantsService(AppDbContext dbContext) : IRestaurantsService
{
    public async Task<IEnumerable<Restaurant>> GetAllRestaurantsAsync()
    {
        return await dbContext.Restaurants.ToListAsync();
    }

    public async Task<Restaurant?> GetRestaurantByIdAsync(Guid id, bool includeDishes = false)
    {
        var restaurants = dbContext.Restaurants;

        if (includeDishes)
            return await dbContext.Restaurants
                .Include(r => r.Dishes)
                .FirstOrDefaultAsync(r => r.Id == id);

        return await dbContext.Restaurants
            .FirstOrDefaultAsync(r => r.Id == id);
    }
}