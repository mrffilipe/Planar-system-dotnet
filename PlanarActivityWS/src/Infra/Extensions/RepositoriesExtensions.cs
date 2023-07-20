using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public static class RepositoriesExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IActivityRepository, ActivityRepository>();

        return services;
    }
}
