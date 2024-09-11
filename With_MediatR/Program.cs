using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using With_MediatR.Events;

public class Program
{
  public static async Task Main(string[] args)
  {
    // Configuration and initialisation of MediatR
    var serviceProvider = ConfigureServices();
    var mediator = serviceProvider.GetRequiredService<IMediator>();

    // Place order and trigger event
    await mediator.Publish(new OrderPlacedEvent(034059020106036052, DateTime.Now, "Walter Hartwell White"));

    Console.ReadLine();
  }

  private static IServiceProvider ConfigureServices()
  {
    var services = new ServiceCollection();

    // Add MediatR
    services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

    // Structure of the service provider
    return services.BuildServiceProvider();
  }
}
