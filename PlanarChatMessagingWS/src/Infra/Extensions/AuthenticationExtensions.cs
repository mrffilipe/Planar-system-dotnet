using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.SignalR;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace PlanarChatMessagingWS.src.Infra;

public static class AuthenticationExtensions
{
    public static IServiceCollection AddAuthenticationConfig(this IServiceCollection services)
    {
        services
            .AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var acessToken = context.Request.Query["access_token"];

                        var path = context.HttpContext.Request.Path;

                        if (!string.IsNullOrEmpty(path)
                            && path.StartsWithSegments("/hubs"))
                        {
                            context.Token = acessToken;
                        }

                        return Task.CompletedTask;
                    }
                };
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("698dc19d489c4e4db73e28a713eab07b")),
                    ValidateIssuer = true,
                    ValidIssuer = "https://localhost:7200",
                    ValidateAudience = true,
                    ValidAudience = "TesteAudience"
                };
            });

        services.AddSingleton<IUserIdProvider, EmailBasedUserIdProvider>();

        return services;
    }
}