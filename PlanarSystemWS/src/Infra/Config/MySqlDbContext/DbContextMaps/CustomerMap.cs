using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

public class CustomerMap : BaseEntityMap<Customer>
{
    public override void Configure(EntityTypeBuilder<Customer> builder)
    {
        base.Configure(builder);

        builder.ToTable("customers");

        builder.Property(x => x.FirstName)
            .HasColumnName("first_name");

        builder.Property(x => x.LastName)
            .HasColumnName("last_name");

        builder.Property(x => x.Email)
            .HasColumnName("email");

        builder.Property(x => x.DocumentId)
            .HasColumnName("document_id");

        builder.Property(x => x.PhoneId)
            .HasColumnName("phone_id");

        builder.Property(x => x.AddressId)
            .HasColumnName("address_id");
    }
}