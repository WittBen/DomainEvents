using MediatR;
using With_MediatR_CQRS.Classes;
using With_MediatR_CQRS.Queries;
using With_MediatR_CQRS.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace With_MediatR_CQRS.Handlers;

public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, List<Order>>
{
  private readonly OrderRepository _orderRepository;

  public GetOrdersQueryHandler(OrderRepository orderRepository)
  {
    _orderRepository = orderRepository;
  }

  public Task<List<Order>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
  {
    // This is where the logic for querying orders would take place

    /*
    #################################################################################
    The database could then be accessed via the repository to determine the data
    
    var orders = await _orderRepository.GetOrdersByCustomerIdAsync(customerId, cancellationToken);
    
    #################################################################################
    */


    // For this simplified example, we return an empty list
    return Task.FromResult(_orderRepository.GetOrdersByCustomer(request.CustomerName));
  }
}
