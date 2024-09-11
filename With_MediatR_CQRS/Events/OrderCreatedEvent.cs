using MediatR;

namespace With_MediatR_CQRS.Events;

public class OrderCreatedEvent : INotification
{
  public long OrderId { get; }
  public string CustomerName { get; }
  public DateTime OrderDate { get; set; }
  public List<string> Products { get; }

  public OrderCreatedEvent(long orderId, string customerName,DateTime orderDate, List<string> products)
  {
    OrderId = orderId;
    CustomerName = customerName;
    OrderDate = orderDate;
    Products = products;
  }
}
