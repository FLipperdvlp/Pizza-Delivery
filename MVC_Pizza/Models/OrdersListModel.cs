using MVC_Pizza.Entities;

namespace MVC_Pizza.Moduls;

public class OrdersListModel
{
    public int OrdersCount { get; set; }
    public int PizzasCount { get; set; }
    public int Revenue { get; set; }

    public IEnumerable<OrderModel> Orders { get; set; } = [];

    public class OrderModel
    {
        public int Id { get; set; }

        public string? ClientName { get; set; }
        public string? ClientPhoneNumber { get; set; }

        public int PizzaId { get; set; }
        public int Quantity { get; set; }

        public bool IsSelfDelivery { get; set; }

        public string? Pizza { get; set; }

        public OrderModel(Order order)
        {
            Id =  order.Id;
            ClientName = order.ClientName;
            ClientPhoneNumber = order.ClientPhoneNumber;
            PizzaId = order.PizzaId;
            Quantity = order.Quantity;
            IsSelfDelivery = order.IsSelfDelivery;
            Pizza = order.Pizza!.Name;
        }
}
}