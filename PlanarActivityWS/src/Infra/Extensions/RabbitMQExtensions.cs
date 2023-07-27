using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public static class RabbitMQExtensions
{
    public static IServiceCollection AddRabbitMQ(this IServiceCollection services)
    {
        services.AddSingleton<IRabbitMQService, RabbitMQService>();

        services.AddHostedService<UserEventConsumer<RegisteredUserEvent>>();

        return services;
    }
}