﻿using Microsoft.AspNetCore.Identity;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Infra;

public static class IdentityExtensions
{
    public static IServiceCollection AddIdentity(this IServiceCollection services)
    {
        services
            .AddScoped<UserManager<CustomIdentityUser>>()
            .AddScoped<SignInManager<CustomIdentityUser>>();

        services.AddIdentityCore<CustomIdentityUser>(options =>
        {
            options.SignIn.RequireConfirmedAccount = true;
        })
            .AddEntityFrameworkStores<MySqlDbContext>()
            .AddDefaultTokenProviders();

        services.Configure<IdentityOptions>(options =>
        {
            // Password settings.


            // Lockout settings.


            // User settings.
        });

        return services;
    }
}