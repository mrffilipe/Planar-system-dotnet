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
            services.AddScoped<IEventHandler<RegisteredUserEvent>, RegisteredUserHandler>();

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
                    var eventConsumer = (IHostedService)provider.GetRequiredService(eventConsumerType);
                    hostedServices.Add(eventConsumer);
                }

                return new CompositeBackgroundService(hostedServices);
            });

            return services;
        }
    }
}
