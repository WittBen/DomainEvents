using With_MediatR_CQRS.Classes;

namespace With_MediatR_CQRS.Repositories;

public class OrderRepository
{
  private readonly List<Order> _orders;

  public OrderRepository()
  {
    _orders = new List<Order>();
  }

  public void Add(Order order)
  {
    _orders.Add(order);
  }

  public List<Order> GetOrdersByCustomer(string customerName)
  {
    return _orders.FindAll(order => order.CustomerName == customerName);
  }
}
