using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using MVC_Pizza.DataBase;
using MVC_Pizza.Entities;
using MVC_Pizza.Moduls;
using MVC_Pizza.Services;

namespace MVC_Pizza.Controllers;

public class PizzaController(PizzaService service) : Controller
{
    public async Task<IActionResult> Order()
    {
        var pizzas = await service.GetAllPizzas();
        
        var model = new OrderModel(pizzas);
        
        return View(model);
    }
    
    [HttpPost]
    public async Task<IActionResult> Order(CreateOrderRequestModel request)
    {
        await service.CreateOrder(request.Name, request.PhoneNumber, request.IsSelfDelivery, request.PizzaId,
            request.Quantity);

        return RedirectToAction(nameof(OrdersList));
    }

    [HttpPost]
    public async Task<IActionResult> DeleteOrder(int orderId)
    {
        await service.DeleteOrder(orderId);
        return RedirectToAction(nameof(OrdersList));
    }

    public async Task<IActionResult> OrdersList()
    {
        var orders = (await service.GetAllOrdersWithIncludedPizza()).ToList();

        var model = new OrdersListModel(orders);

        return View(model);
    }
}