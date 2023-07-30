using Microsoft.EntityFrameworkCore;

namespace PlanarAuthenticationWS.src.Infra;

public static class DbContextExtensions
{
    private const string MYSQL_CONNECTION = "Server=localhost;Database=planar-authentication-db;Uid=root;Pwd=root;";

    public static IServiceCollection AddMySqlDbContext(this IServiceCollection services)
    {
        services.AddDbContext<MySqlDbContext>(options =>
        {
            options.UseMySql(MYSQL_CONNECTION, ServerVersion.AutoDetect(MYSQL_CONNECTION));
        });

        return services;
    }
}