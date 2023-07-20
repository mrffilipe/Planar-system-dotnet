using PlanarUserAccountWS.src.Application;

namespace PlanarUserAccountWS.src.Infra;

public static class AdaptersExtensions
{
    public static IServiceCollection AddAdapters(this IServiceCollection services)
    {
        services.AddScoped<IUserAccountAdapter, UserAccountAdapter>();

        return services;
    }
}
