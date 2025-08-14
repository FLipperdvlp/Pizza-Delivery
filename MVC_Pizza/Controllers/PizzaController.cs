using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Pizza.DataBase;
using MVC_Pizza.Entities;
using MVC_Pizza.Moduls;

namespace MVC_Pizza.Controllers;

public class PizzaController(PizzaDBContext pizzaDbContext) : Controller
{
    public async Task<IActionResult> Order()
    {
        var pizzas = await pizzaDbContext.Pizzas.ToListAsync();
    
        var model = new OrderModel
        {
            SelectPizza = pizzas.Select(pizza => new OrderModel.SelectPizzaModel(pizza))
        };
    
        return View(model);
    }

    [HttpPost]
    public IActionResult Order(CreateOrderRequestModel request)
    {
        return View();
    }

    public async Task<IActionResult> OrderList()
    {
        var orders = await pizzaDbContext.Orders
            .Include(o => o.Pizza)
            .ToListAsync();

        var model = new OrdersListModel
        {
            Orders = orders.Select(order => new OrdersListModel.OrderModel(order)),
            OrdersCount = orders.Count,
            PizzasCount = orders.Sum(o => o.Quantity),
            Revenue = (int)orders.Sum(o => o.Quantity * o.Pizza!.Price),
            
        };
        
        return View(model);
    }
}
