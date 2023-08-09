using PlanarAuthenticationWS.src.Application;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Infra;

public static class EventHandlerExtensions
{
    public static IServiceCollection AddEventHandlers(this IServiceCollection services)
    {
        services.AddScoped<IEventHandler<DetailedUserCreatedEvent>, DetailedUserCreatedEventHandler>();
        //services.AddScoped<IEventHandler<UpdatedUserEvent>, UpdatedUserHandler>();

        return services;
    }
}