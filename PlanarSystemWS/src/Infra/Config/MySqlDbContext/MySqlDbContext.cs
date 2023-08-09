using Microsoft.EntityFrameworkCore;
using PlanarSalesWS.src.Domain;
using System.Reflection;

namespace PlanarSalesWS.src.Infra;

public class MySqlDbContext : DbContext
{
    public DbSet<RefAddress> Adresses { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<RefDocument> Documents { get; set; }
    public DbSet<RefPhone> Phones { get; set; }
    public DbSet<RefBudgetForm> BudgetForms { get; set; }
    public DbSet<Seller> Sellers { get; set; }

    public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}