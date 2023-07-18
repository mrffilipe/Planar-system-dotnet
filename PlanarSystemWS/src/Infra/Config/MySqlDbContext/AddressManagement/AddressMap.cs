using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.AddressManagement;
using PlanarSystemWS.src.Domain.CustomerManagement;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.AddressManagement;

public class AddressMap : BaseEntityMap<RefAddress>
{
    public override void Configure(EntityTypeBuilder<RefAddress> builder)
    {
        base.Configure(builder);

        builder.OwnsOne(typeof(Address), "Address");

        builder.HasOne(e => e.Customer)
            .WithOne(e => e.Address)
            .HasForeignKey<Customer>(e => e.AddressId)
            .IsRequired();

        builder.HasOne(e => e.BudgetForm)
            .WithOne(e => e.InstallationAddress)
            .HasForeignKey<RefBudgetForm>(e => e.InstallationAddressId)
            .IsRequired();
    }
}
