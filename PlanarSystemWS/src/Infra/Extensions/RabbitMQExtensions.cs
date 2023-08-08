using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Infra;

public static class RabbitMQExtensions
{
    public static IServiceCollection AddRabbitMQ(this IServiceCollection services)
    {
        services.AddSingleton<IRabbitMQService, RabbitMQService>();

        services.AddHostedService<RegisteredUserEventConsumer<RegisteredUserEvent>>();

        return services;
    }
}