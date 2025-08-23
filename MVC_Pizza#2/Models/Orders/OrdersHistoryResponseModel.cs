using NeGlovo.Entities;
using NeGlovo.Entities.Owned;
using NeGlovo.Enums;

namespace NeGlovo.Models.Orders;

public class OrdersHistoryResponseModel
{
    public IEnumerable<OrderModel> Orders { get; set; }

    public OrdersHistoryResponseModel(IEnumerable<Order> orders)
    {
        Orders = orders.Select(o => new OrderModel(o))
            .OrderByDescending(o => o.CreatedAt);
    }

    public class OrderModel
    {
        public Guid Id { get; set; }
        public Coordinates DestinationCoordinates { get; set; }
        public string Status { get; set; }
        public Guid RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public Guid CourierId { get; set; }
        public string CourierName { get; set; }
        public DateTime CreatedAt { get; set; }

        public OrderModel(Order order)
        {
            Id = order.Id;
            DestinationCoordinates = order.DestinationCoordinates;
            RestaurantId = order.RestaurantId;
            Status = order.Status.ToString();
            RestaurantName = order.Restaurant!.Name;
            CourierId = order.CourierId;
            CourierName = order.Courier!.Name;
            CreatedAt = order.CreatedAt;
        }
    }
}