using PlanarSalesWS.src.Application;

namespace PlanarSalesWS.src.Infra;

public static class AdaptersExtensions
{
    public static IServiceCollection AddAdapters(this IServiceCollection services)
    {
        services.AddScoped<ISalesAdapter, SalesAdapter>();
        services.AddScoped<ISolarEnergyAdapter, SolarEnergyAdapter>();

        return services;
    }
}