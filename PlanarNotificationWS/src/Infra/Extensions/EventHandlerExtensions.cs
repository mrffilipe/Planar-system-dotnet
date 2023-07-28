using PlanarNotificationWS.src.Application;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Infra;

public static class EventHandlerExtensions
{
    public static IServiceCollection AddEventHandlers(this IServiceCollection services)
    {
        services.AddScoped<IEventHandler<RegisteredUserEvent>, RegisteredUserHandler>();
        services.AddScoped<IEventHandler<UpdatedUserEvent>, UpdatedUserHandler>();
        services.AddScoped<IEventHandler<RegisteredNotificationEvent>, RegisteredNotificationHandler>();

        return services;
    }
}