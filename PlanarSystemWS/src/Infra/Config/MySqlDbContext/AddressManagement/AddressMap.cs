using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.AddressManagement;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.AddressManagement;

public class AddressMap : BaseEntityMap<RefAddress>
{
    public override void Configure(EntityTypeBuilder<RefAddress> builder)
    {
        base.Configure(builder);

        builder.HasOne(e => e.Customer)
            .WithOne(e => e.Address)
            .HasForeignKey<Customer>(e => e.AddressId)
            .IsRequired();

        builder.OwnsOne(typeof(Address), "Address");
    }
}
