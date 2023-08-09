using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

public class AddressMap : BaseEntityMap<RefAddress>
{
    public override void Configure(EntityTypeBuilder<RefAddress> builder)
    {
        base.Configure(builder);

        builder.ToTable("adresses");

        builder.OwnsOne(e => e.Address, address =>
        {
            address.Property(x => x.PostalCode)
                .HasColumnName("postal_code");

            address.Property(x => x.City)
                .HasColumnName("city");

            address.Property(x => x.State)
                .HasColumnName("state");

            address.Property(x => x.Country)
                .HasColumnName("country");

            address.Property(x => x.District)
                .HasColumnName("district");

            address.Property(x => x.Street)
                .HasColumnName("street");

            address.Property(x => x.Complement)
                .HasColumnName("complement");
        });

        builder.HasOne(e => e.Customer)
            .WithOne(e => e.Address)
            .HasForeignKey<Customer>(e => e.AddressId)
            .IsRequired();
    }
}