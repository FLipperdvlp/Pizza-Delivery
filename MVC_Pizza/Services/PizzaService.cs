using Microsoft.EntityFrameworkCore;
using MVC_Pizza.DataBase;
using MVC_Pizza.Entities;

namespace MVC_Pizza.Services;

public class PizzaService(PizzaDBContext dbContext)
{
    public async Task<IEnumerable<Pizza>> GetAllPizzas()
    {
        return await dbContext.Pizzas.ToListAsync();
    }

    public async Task<Order> CreateOrder(string clientName, string clientPhone, bool isSelfDelivery, int pizzaId,
        int quantity)
    {
        // ClientName = request.Name,
        // ClientPhone = request.Phone,
        // IsSelfDelivery = request.IsSelfDelivery,
        // PizzaId = request.PizzaId,
        // Quantity = request.Quantity

        var newOrder = new Order
        {
            ClientName = clientName,
            ClientPhoneNumber = clientPhone,
            IsSelfDelivery = isSelfDelivery,
            PizzaId = pizzaId,
            Quantity = quantity
        };

        dbContext.Orders.Add(newOrder);
        await dbContext.SaveChangesAsync();

        return newOrder;
    }

    public async Task<bool> DeleteOrder(int orderId)
    {
        var order = await dbContext.Orders.FindAsync(orderId);

        if (order is null)
            return false;

        dbContext.Orders.Remove(order);
        await dbContext.SaveChangesAsync();

        return true;
    }

    public async Task<IEnumerable<Order>> GetAllOrdersWithIncludedPizza()
    {
        return await dbContext.Orders.Include(o => o.Pizza).ToListAsync();
    }
}