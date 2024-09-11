using MediatR;
using With_MediatR.Events;

namespace With_MediatR.Handlers;

public class OrderPlacedEventHandler : INotificationHandler<OrderPlacedEvent>
{
  public Task Handle(OrderPlacedEvent notification, CancellationToken cancellationToken)
  {
    Console.WriteLine($"New order received: ID={notification.OrderId}, Date={notification.OrderDate}, Customer={notification.CustomerName}");
    // Further actions could be carried out here, e.g. send confirmation e-mail
    return Task.CompletedTask;
  }
}
