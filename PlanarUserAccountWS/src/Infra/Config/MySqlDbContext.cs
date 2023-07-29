using Microsoft.EntityFrameworkCore;
using PlanarUserAccountWS.src.Domain;
using System.Reflection;

namespace PlanarUserAccountWS.src.Infra;

public class MySqlDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<RefUserRole> UserRole { get; set; }
    public DbSet<RefUserClaim> UserClaim { get; set; }

    public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}