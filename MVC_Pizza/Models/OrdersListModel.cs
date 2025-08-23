using MVC_Pizza.Entities;

namespace MVC_Pizza.Moduls;

public class OrdersListModel
{
    public int OrdersCount { get; set; }
    
    public int PizzasCount { get; set; }
    
    public int Revenue { get; set; }
    
    public IEnumerable<OrderModel> Orders { get; set; } = [];

    public OrdersListModel(List<Order> orders)
    {
        Orders = orders.Select(order => new OrdersListModel.OrderModel(order));
        OrdersCount = orders.Count;
        PizzasCount = orders.Sum(o => o.Quantity);
        Revenue = (int)orders.Sum(o => o.Quantity * o.Pizza!.Price);
    }

    public class OrderModel
    {
        public int Id { get; set; }
        public string ClientName { get; set; } = null!;
        public string ClientPhone { get; set; } = null!;
        public int Quantity { get; set; }
        
        public bool IsSelfDelivery { get; set; }
        
        public string Pizza { get; set; } = null!;

        public OrderModel(Order order)
        {
            Id = order.Id;
            ClientName = order.ClientName;
            ClientPhone = order.ClientPhoneNumber;
            Quantity = order.Quantity;
            IsSelfDelivery = order.IsSelfDelivery;
            Pizza = order.Pizza!.Name;
        }
    }
}