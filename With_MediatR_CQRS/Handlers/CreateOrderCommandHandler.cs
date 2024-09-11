using MediatR;
using With_MediatR_CQRS.Commands;
using With_MediatR_CQRS.Events;

namespace With_MediatR_CQRS.Handlers;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand>
{
  private readonly IMediator _mediator;

  public CreateOrderCommandHandler(IMediator mediator)
  {
    _mediator = mediator;
  }

  public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
  {
    // This is where the logic for creating a new order would take place
    Console.WriteLine($"New order created at {request.OrderDate}: ID={request.OrderId}, Customer={request.CustomerName}");

    // Triggering the domain event "Order created"
    await _mediator.Publish(new OrderCreatedEvent(request.OrderId, request.CustomerName, request.OrderDate, request.Products));

  }
}
