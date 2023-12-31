﻿namespace PlanarUserAccountWS.src.Infra;

public static class RabbitMQExtensions
{
    public static IServiceCollection AddRabbitMQ(this IServiceCollection services)
    {
        services.AddSingleton<IRabbitMQService, RabbitMQService>();

        services.AddScoped(typeof(EventProducer<>));

        return services;
    }
}
