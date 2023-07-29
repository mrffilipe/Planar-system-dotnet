using Microsoft.EntityFrameworkCore;

namespace PlanarUserAccountWS.src.Infra;

public static class DbContextExtensions
{
    private const string MYSQL_CONNECTION = "Server=localhost;Database=planar-user-account-db;Uid=root;Pwd=root;";

    public static IServiceCollection AddDbContexts(this IServiceCollection services)
    {
        services.AddDbContext<MySqlDbContext>(
            options => options.UseMySql(MYSQL_CONNECTION, ServerVersion.AutoDetect(MYSQL_CONNECTION)));

        return services;
    }
}
