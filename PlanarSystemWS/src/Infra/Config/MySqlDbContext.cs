using Microsoft.EntityFrameworkCore;

namespace PlanarSystemWS.src.Infra;

public class MySqlDbContext : DbContext
{
    public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
    {

    }
}
