using NeGlovo.Entities;
using NeGlovo.Enums;

namespace NeGlovo.Interfaces;

public interface IOrdersService
{
    // Отримати замовлення по айді клієнта
    Task<IEnumerable<Order>> GetOrdersByClientIdAsync(Guid clientId);

    // Отримати очікуючі замовлення
    Task<IEnumerable<Order>> GetPendingOrdersAsync();

    // Отримати замовлення по айді
    Task<Order?> GetOrderByIdAsync(Guid id);

    // Прив'язати кур'єра до замовлення
    Task<Order> SetCourierToOrderAsync(Guid orderId, Guid courierId);

    // Змінити статус замовлення
    Task<Order> ChangeOrderStatusAsync(Guid orderId, OrderStatus status);
}