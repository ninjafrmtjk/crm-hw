using Crm;

public sealed class OrderService
{

    private List<Order> orderList;
    public OrderService()
    {
        orderList = new List<Order>();
    }
    public Order CreateOrder(OrderInfo orderInfo)
    {
        Order newOrder = new Order();
        orderList.Add(newOrder);
        return newOrder;
    }   

    public Order GetOrder(string description, int id)
    [
        return orderList.FirstOrDefault(order => order.Description == description && order.Id == id);
    ]
}