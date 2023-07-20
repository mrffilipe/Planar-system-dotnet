using PlanarNotificationWS.src.Application;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Infra;

public static class ServicesExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<INotificationService, NotificationService>();

        return services;
    }
}
