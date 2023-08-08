using PlanarSystemWS.src.Application.UserManagement;
using PlanarSystemWS.src.Domain.Shared;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Infra;

public static class EventHandlerExtensions
{
    public static IServiceCollection AddEventHandlers(this IServiceCollection services)
    {
        services.AddScoped<IEventHandler<RegisteredUserEvent>, RegisteredUserHandler>();

        return services;
    }
}