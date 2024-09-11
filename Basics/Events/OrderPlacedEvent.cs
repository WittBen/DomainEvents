namespace Basics.Events;

public class OrderPlacedEvent
{
  public long OrderId { get; set; }
  public DateTime OrderDate { get; set; }
  public string CustomerName { get; set; }

  public OrderPlacedEvent(long orderId, DateTime orderDate, string customerName)
  {
    OrderId = orderId;
    OrderDate = orderDate;
    CustomerName = customerName;
  }
}
