using MediatR;
using With_MediatR_CQRS.Classes;
using With_MediatR_CQRS.Events;
using With_MediatR_CQRS.Repositories;

namespace With_MediatR_CQRS.EventHandlers;

public class OrderCreatedEventHandler : INotificationHandler<OrderCreatedEvent>
{
    private readonly OrderRepository _orderRepository;

    public OrderCreatedEventHandler(OrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public Task Handle(OrderCreatedEvent notification, CancellationToken cancellationToken)
    {
        // For this example, we simulate the receipt of the order 15 minutes after the order was placed
        Console.WriteLine($"New order received at {DateTime.Now.AddMinutes(+15)}: ID={notification.OrderId}, Customer={notification.CustomerName}");

        foreach (var product in notification.Products)
        {
            Console.WriteLine($"Product added: {product}");
        }

        // Save the order in the repository
        _orderRepository.Add(new Order(notification.OrderId, notification.CustomerName, notification.OrderDate, notification.Products));

        return Task.CompletedTask;
    }
}
