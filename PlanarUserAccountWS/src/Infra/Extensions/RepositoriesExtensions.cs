using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Infra;

public static class RepositoriesExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IUserAccountRepository, UserAccountRepository>();

        return services;
    }
}
