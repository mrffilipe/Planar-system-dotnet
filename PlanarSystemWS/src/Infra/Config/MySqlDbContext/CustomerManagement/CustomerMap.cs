using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.CustomerManagement;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.CustomerManagement;

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

        builder.HasOne(e => e.BudgetForm)
            .WithOne(e => e.Customer)
            .HasForeignKey<RefBudgetForm>(e => e.CustomerId)
            .IsRequired();
    }
}
