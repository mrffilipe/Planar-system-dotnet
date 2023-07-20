using PlanarUserAccountWS.src.Application;
using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Infra;

public static class ServicesExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IUserAccountService, UserAccountService>();

        return services;
    }
}
