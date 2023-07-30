using PlanarAuthenticationWS.src.Application;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Infra;

public static class ServicesExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationService, AuthenticationService>();

        return services;
    }
}