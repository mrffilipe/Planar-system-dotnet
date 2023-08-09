using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

public static class RepositoriesExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ISalesRepository, SalesRepository>();
        services.AddScoped<ISolarEnergyRepository, SolarEnergyRepository>();

        return services;
    }
}