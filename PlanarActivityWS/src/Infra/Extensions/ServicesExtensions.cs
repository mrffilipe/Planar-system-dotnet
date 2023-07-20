using PlanarActivityWS.src.Application;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public static class ServicesExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IActivityService, ActivityService>();

        return services;
    }
}
