using NeGlovo.Entities;
using NeGlovo.Entities.Owned;

namespace NeGlovo.Models.Orders;

public class PendingOrdersResponseModel
{
    public IEnumerable<OrderModel> Orders { get; set; }

    public PendingOrdersResponseModel(IEnumerable<Order> orders)
    {
        Orders = orders.Select(o => new OrderModel(o))
            .OrderBy(o => o.CreatedAt);
    }

    public class OrderModel
    {
        public Guid Id { get; set; }
        public Coordinates DestinationCoordinates { get; set; }
        public Guid RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }
        public DateTime CreatedAt { get; set; }

        public OrderModel(Order order)
        {
            Id = order.Id;
            DestinationCoordinates = order.DestinationCoordinates;
            RestaurantId = order.RestaurantId;
            RestaurantName = order.Restaurant!.Name;
            CreatedAt = order.CreatedAt;
            RestaurantAddress = order.Restaurant.Address;
        }
    }
}