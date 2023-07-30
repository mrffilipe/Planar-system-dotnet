using PlanarAuthenticationWS.src.Application;

namespace PlanarAuthenticationWS.src.Infra;

public static class AdaptersExtensions
{
    public static IServiceCollection AddAdapters(this IServiceCollection services)
    {
        services.AddScoped<IAuthenticationAdapter, AuthenticationAdapter>();

        return services;
    }
}