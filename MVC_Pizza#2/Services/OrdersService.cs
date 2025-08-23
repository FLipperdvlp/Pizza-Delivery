using Microsoft.EntityFrameworkCore;
using NeGlovo.Database;
using NeGlovo.Entities;
using NeGlovo.Enums;
using NeGlovo.Interfaces;

namespace NeGlovo.Services;

public class OrdersService(AppDbContext dbContext) : IOrdersService
{
    public async Task<IEnumerable<Order>> GetOrdersByClientIdAsync(Guid clientId)
    {
        return await dbContext.Orders
            .Include(o => o.Restaurant)
            .Include(o => o.Courier)
            .Where(o => o.ClientId == clientId)
            .ToListAsync();
    }

    public async Task<IEnumerable<Order>> GetPendingOrdersAsync()
    {
        return await dbContext.Orders
            .Include(o => o.Restaurant)
            .Include(o => o.Courier)
            .Where(o => o.Status == OrderStatus.Pending)
            .ToListAsync();
    }

    public async Task<Order?> GetOrderByIdAsync(Guid id)
    {
        return await dbContext.Orders
            .Include(o => o.Restaurant)
            .Include(o => o.Courier)
            .FirstOrDefaultAsync(o => o.Id == id);
    }

    public async Task<Order> SetCourierToOrderAsync(Guid orderId, Guid courierId)
    {
        var order = await dbContext.Orders.FindAsync(orderId);

        if (order is null)
            throw new Exception("Order with given id not found");

        order.Status = OrderStatus.Accepted;
        order.CourierId = courierId;
        await dbContext.SaveChangesAsync();

        return order;
    }

    public async Task<Order> ChangeOrderStatusAsync(Guid orderId, OrderStatus status)
    {
        var order = await dbContext.Orders.FindAsync(orderId);

        if (order is null)
            throw new Exception("Order with given id not found");

        order.Status = status;
        await dbContext.SaveChangesAsync();

        return order;
    }
}