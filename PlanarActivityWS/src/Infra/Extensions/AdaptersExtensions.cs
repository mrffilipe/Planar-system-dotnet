using PlanarActivityWS.src.Application;

namespace PlanarActivityWS.src.Infra;

public static class AdaptersExtensions
{
    public static IServiceCollection AddAdapters(this IServiceCollection services)
    {
        services.AddScoped<IActivityAdapter, ActivityAdapter>();

        return services;
    }
}
