using Consul;

namespace PlanarSystemWS.src.Infra
{
    public static class ConsulExtensions
    {
        public static IServiceCollection AddConsul(this IServiceCollection services)
        {
            services.AddSingleton<IConsulClient, ConsulClient>(
                provider => new ConsulClient(
                    config => config.Address = new Uri("http://localhost:8500")
                )
            );

            return services;
        }

        public static IApplicationBuilder UseConsul(this IApplicationBuilder app)
        {
            using (var client = new ConsulClient())
            {
                var lifetime = app.ApplicationServices.GetRequiredService<IHostApplicationLifetime>();
                var logger = app.ApplicationServices.GetRequiredService<ILoggerFactory>().CreateLogger("AppExtensions");

                var registration = new AgentServiceRegistration()
                {
                    ID = "planar-system",
                    Name = "planar-system-ws",
                    Address = "localhost",
                    Port = 7205
                };

                logger.LogInformation("Registering service in Consul");

                client.Agent.ServiceDeregister(registration.ID).ConfigureAwait(true);
                client.Agent.ServiceRegister(registration).ConfigureAwait(true);

                logger.LogInformation("Service registered with the Consul");

                lifetime.ApplicationStopping.Register(() =>
                {
                    logger.LogInformation("Unregistering from the Consul");

                    client.Agent.ServiceDeregister(registration.ID).ConfigureAwait(true);

                    logger.LogInformation("Consul unregistered service");
                });
            }

            return app;
        }
    }
}