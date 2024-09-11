using MediatR;
using With_MediatR_CQRS.Classes;

namespace With_MediatR_CQRS.Queries;

public class GetOrdersQuery : IRequest<List<Order>>
{
  public string CustomerName { get; set; }
}
