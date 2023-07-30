using Microsoft.AspNetCore.Identity;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Infra;

public static class IdentityExtensions
{
    public static IServiceCollection AddIdentity(this IServiceCollection services)
    {
        services.AddIdentityCore<CustomIdentityUser>(options =>
        {
            options.SignIn.RequireConfirmedAccount = true;
        })
            .AddEntityFrameworkStores<MySqlDbContext>();

        services.Configure<IdentityOptions>(options =>
        {
            // Password settings.


            // Lockout settings.


            // User settings.
        });

        return services;
    }
}