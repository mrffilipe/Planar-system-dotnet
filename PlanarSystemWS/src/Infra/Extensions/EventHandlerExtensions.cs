using PlanarSystemWS.src.Application.UserManagement;
using PlanarSystemWS.src.Domain.Shared;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Infra
{
    public static class EventHandlerExtensions
    {
        public static IServiceCollection AddEventHandlers(this IServiceCollection services)
        {
            // Event handlers
            //services.AddScoped<IEventHandler<RegisteredUserEvent>, RegisteredUserHandler>(); -- verificar o porque do erro
            services.AddSingleton<IEventHandler<RegisteredUserEvent>, RegisteredUserHandler>();

            // RabbitMQ
            services.AddSingleton<IRabbitMQService, RabbitMQService>(); // --verificar o porque do erro

            // Producer and consumer
            services.AddScoped(typeof(EventConsumer<>));
            services.AddScoped(typeof(EventProducer<>));

            services.AddHostedService(provider =>
            {
                var eventTypes = new[]
                {
                    typeof(RegisteredUserEvent),
                };

                var hostedServices = new List<IHostedService>();

                foreach (var eventType in eventTypes)
                {
                    var eventConsumerType = typeof(EventConsumer<>).MakeGenericType(eventType);
                    //var eventConsumer = (IHostedService)provider.GetRequiredService(eventConsumerType); -- verificar o porque do erro
                    var eventConsumer = (IHostedService)ActivatorUtilities.CreateInstance(provider, eventConsumerType);
                    hostedServices.Add(eventConsumer);
                }

                return new CompositeBackgroundService(hostedServices);
            });

            return services;
        }
    }
}
