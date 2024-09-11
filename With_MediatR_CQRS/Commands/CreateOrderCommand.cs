using MediatR;

namespace With_MediatR_CQRS.Commands;

public class CreateOrderCommand : IRequest
{
  public long OrderId { get; set; }
  public string CustomerName { get; set; }
  public DateTime OrderDate { get; set; }
  public List<string> Products { get; set; }
}
