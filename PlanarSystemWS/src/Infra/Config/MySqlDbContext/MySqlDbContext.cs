using Microsoft.EntityFrameworkCore;
using PlanarSystemWS.src.Infra.Config.MySqlDbContext.AddressManagement;
using PlanarSystemWS.src.Infra.Config.MySqlDbContext.CustomerManagement;
using PlanarSystemWS.src.Infra.Config.MySqlDbContext.UserManagement;
using System.Reflection;

namespace PlanarSystemWS.src.Infra;

public class MySqlDbContext : DbContext
{
    public DbSet<AddressMap> Adresses { get; set; }
    public DbSet<CustomerMap> Customers { get; set; }
    public DbSet<DocumentMap> Documents { get; set; }
    public DbSet<PhoneMap> Phones { get; set; }
    public DbSet<UserMap> Users { get; set; }

    public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
