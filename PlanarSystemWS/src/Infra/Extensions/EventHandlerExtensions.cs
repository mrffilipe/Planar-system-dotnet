using PlanarSalesWS.src.Application;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

public static class EventHandlerExtensions
{
    public static IServiceCollection AddEventHandlers(this IServiceCollection services)
    {
        services.AddScoped<IEventHandler<RegisteredUserEvent>, RegisteredUserHandler>();

        return services;
    }
}