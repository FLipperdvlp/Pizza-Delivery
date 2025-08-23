using Microsoft.AspNetCore.Mvc;
using NeGlovo.Interfaces;
using NeGlovo.Models.Orders;

namespace NeGlovo.Controllers;

[Route("orders")]
public class OrdersController(IOrdersService ordersService) : Controller
{
    // тимчасовий id клієнта, котрий робити запити на сервер
    private readonly Guid _tempClientId = Guid.Parse("8a5b2c3d-4e5f-6a7b-8c9d-0e1f2a3b4c5d");
    
    // Переглянути історію замовлень
    [Route("history")]
    public async Task<IActionResult> OrdersHistory()
    {
        // отримуємо замовлення по айді клієнта
        var orders = await ordersService.GetOrdersByClientIdAsync(_tempClientId);
        
        // модель
        return View(new OrdersHistoryResponseModel(orders));
    }

    // Створити замовлення
    [Route("create")]
    [HttpPost]
    public async Task<IActionResult> CreateOrder()
    {
        await Task.Delay(0); // тимчасова "заглушка" щоб не ругався async
        return View();
    }
    
    // Список очікуючих кур'єра замовлень
    [Route("pending")]
    public async Task<IActionResult> PendingOrders()
    {
        // отримуємо замовлення що очікують взяття
        var orders = await ordersService.GetPendingOrdersAsync();
        
        // модель
        return View(new PendingOrdersResponseModel(orders));
    }
    
    // Отримати замовлення по айді
    [Route("{id:guid}")]
    public async Task<IActionResult> Order(Guid id)
    {
        var order = await ordersService.GetOrderByIdAsync(id);
        
        // ...
        
        return View();
    }
    
    // Прийняти замовлення
    [Route("{id:guid}/accept")]
    [HttpPost]
    public async Task<IActionResult> AcceptOrder(Guid id)
    {
        await Task.Delay(0); // тимчасова "заглушка" щоб не ругався async
        return View();
    }
    
    // Отримати замовлення в закладі та почати доставляти людині
    [Route("{id:guid}/deliver")]
    [HttpPost]
    public async Task<IActionResult> StartDeliveringOrder(Guid id)
    {
        await Task.Delay(0); // тимчасова "заглушка" щоб не ругався async
        return View();
    }
    
    // Отримати замовлення в закладі та почати доставляти людині
    [Route("{id:guid}/complete")]
    [HttpPost]
    public async Task<IActionResult> CompleteOrder(Guid id)
    {
        await Task.Delay(0); // тимчасова "заглушка" щоб не ругався async
        return View();
    }
}