using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using NeGlovo.Interfaces;
using NeGlovo.Models.Restaurants;

namespace NeGlovo.Controllers;

[Route("restaurants")]
public class RestaurantsController(IRestaurantsService restaurantsService) : Controller
{
    // Отримати список усіх ресторанів
    [Route("list")]
    public async Task<IActionResult> RestaurantsList()
    {
        // отримуємо всі ресторани
        var restaurants = await restaurantsService.GetAllRestaurantsAsync();
        
        // із масиву ресторанів будуємо модель та передаємо на сторінку
        return View(new RestaurantsListViewModel(restaurants));
    }

    // Отримати дані про ресторан та його меню по вказаному айді
    [Route("{id:guid}")]
    public async Task<IActionResult> Restaurant(Guid id)
    {
        // шукаємо заклад зі вказаним id
        var restaurant = await restaurantsService.GetRestaurantByIdAsync(id, true);

        // якщо не знайшли вказаний ресторан - направити користувача на сторінку з усіма закладами
        if (restaurant is null)
            return RedirectToAction(nameof(RestaurantsList));
        
        // формуємо модель та передаємо на сторінку
        return View(new RestaurantViewModel(restaurant));
    }

    // Редагувати інфу про заклад та його меню
    [Route("{id:guid}/edit")]
    [HttpPost]
    public async Task<IActionResult> EditRestaurant(Guid id)
    {
        await Task.Delay(0); // тимчасова "заглушка" щоб не ругався async
        return View();
    }
}