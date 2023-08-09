using PlanarSalesWS.src.Application;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

public static class ServicesExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ISalesService, SalesService>();
        services.AddScoped<ISolarEnergyService, SolarEnergyService>();

        return services;
    }
}