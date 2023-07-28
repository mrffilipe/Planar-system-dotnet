using PlanarActivityWS.src.Application;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public static class EventHandlerExtensions
{
    public static IServiceCollection AddEventHandlers(this IServiceCollection services)
    {
        services.AddScoped<IEventHandler<RegisteredUserEvent>, RegisteredUserHandler>();
        services.AddScoped<IEventHandler<UpdatedUserEvent>, UpdatedUserHandler>();
        services.AddScoped<IEventHandler<RegisteredActivityEvent>, RegisteredActivityHandler>();
        services.AddScoped<IEventHandler<UpdatedActivityEvent>, UpdatedActivityHandler>();

        return services;
    }
}