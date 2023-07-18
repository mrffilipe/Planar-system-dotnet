using Microsoft.EntityFrameworkCore;
using PlanarSystemWS.src.Domain.AddressManagement;
using PlanarSystemWS.src.Domain.CustomerManagement;
using PlanarSystemWS.src.Domain.UserManagement;
using System.Reflection;

namespace PlanarSystemWS.src.Infra;

public class MySqlDbContext : DbContext
{
    public DbSet<RefAddress> Adresses { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<RefDocument> Documents { get; set; }
    public DbSet<RefPhone> Phones { get; set; }
    public DbSet<User> Users { get; set; }

    public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
