namespace Basics.Events;

public static class EventBus
{
  public static event EventHandler<OrderPlacedEvent>? OrderPlaced;

  public static void PublishOrderPlacedEvent(long orderId, DateTime orderDate, string customerName)
  {
    var orderPlacedEvent = new OrderPlacedEvent(orderId, orderDate, customerName);
    OnOrderPlaced(orderPlacedEvent);
  }

  private static void OnOrderPlaced(OrderPlacedEvent e)
  {
    OrderPlaced?.Invoke(null, e);
  }
}
