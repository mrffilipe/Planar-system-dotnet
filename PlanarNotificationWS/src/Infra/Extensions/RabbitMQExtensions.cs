using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Infra;

public static class RabbitMQExtensions
{
    public static IServiceCollection AddRabbitMQ(this IServiceCollection services)
    {
        services.AddSingleton<IRabbitMQService, RabbitMQService>();

        services.AddHostedService<RegisteredUserEventConsumer<RegisteredUserEvent>>();
        services.AddHostedService<UpdatedUserEventConsumer<RegisteredUserEvent>>();
        services.AddHostedService<RegisteredNotificationEventConsumer<RegisteredNotificationEvent>>();

        return services;
    }
}