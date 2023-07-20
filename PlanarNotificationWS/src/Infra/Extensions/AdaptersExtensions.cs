using PlanarNotificationWS.src.Application;

namespace PlanarNotificationWS.src.Infra;

public static class AdaptersExtensions
{
    public static IServiceCollection AddAdapters(this IServiceCollection services)
    {
        services.AddScoped<INotificationAdapter, NotificationAdapter>();

        return services;
    }
}
