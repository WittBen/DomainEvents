using Basics.Events;
public class Program
{
  public static void Main(string[] args)
  {
    // Subscription to the "Order placed" event
    EventBus.OrderPlaced += HandleOrderPlacedEvent;

    // Place order and trigger event
    PlaceOrder(034059020106036052, DateTime.Now, "Walter Hartwell White");
  }

  public static void PlaceOrder(long orderId, DateTime orderDate, string customerName)
  {
    // The logic for order processing would take place here

    // Triggering the "Order placed" event
    EventBus.PublishOrderPlacedEvent(orderId, orderDate, customerName);
  }

  public static void HandleOrderPlacedEvent(object sender, OrderPlacedEvent e)
  {
    Console.WriteLine($"New order received: ID={e.OrderId}, Date={e.OrderDate}, Customer={e.CustomerName}");

    // Further actions could be carried out here, e.g. send confirmation e-mail
  }
}

