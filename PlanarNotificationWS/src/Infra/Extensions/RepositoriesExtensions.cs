using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Infra;

public static class RepositoriesExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<INotificationRepository, NotificationRepository>();

        return services;
    }
}
