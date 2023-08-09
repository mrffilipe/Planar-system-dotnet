using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

public static class RabbitMQExtensions
{
    public static IServiceCollection AddRabbitMQ(this IServiceCollection services)
    {
        services.AddSingleton<IRabbitMQService, RabbitMQService>();

        services.AddHostedService<RegisteredUserEventConsumer<RegisteredUserEvent>>();

        return services;
    }
}