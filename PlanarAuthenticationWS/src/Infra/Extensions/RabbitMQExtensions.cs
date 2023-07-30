using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Infra;

public static class RabbitMQExtensions
{
    public static IServiceCollection AddRabbitMQ(this IServiceCollection services)
    {
        services.AddSingleton<IRabbitMQService, RabbitMQService>();

        services.AddHostedService<RegisteredUserEventConsumer<RegisteredUserEvent>>();
        //services.AddHostedService<UpdatedUserEventConsumer<RegisteredUserEvent>>();
        //services.AddHostedService<RegisteredActivityEventConsumer<RegisteredUserEvent>>();
        //services.AddHostedService<UpdatedActivityEventConsumer<RegisteredUserEvent>>();

        return services;
    }
}