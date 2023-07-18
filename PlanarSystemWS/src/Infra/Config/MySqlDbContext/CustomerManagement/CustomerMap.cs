using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.CustomerManagement;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.CustomerManagement;

public class CustomerMap : BaseEntityMap<Customer>
{
    public override void Configure(EntityTypeBuilder<Customer> builder)
    {
        base.Configure(builder);

        builder.HasOne(e => e.BudgetForm)
            .WithOne(e => e.Customer)
            .HasForeignKey<RefBudgetForm>(e => e.CustomerId)
            .IsRequired();
    }
}
