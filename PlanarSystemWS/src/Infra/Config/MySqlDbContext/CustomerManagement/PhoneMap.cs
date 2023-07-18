using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.CustomerManagement;

public class PhoneMap : BaseEntityMap<RefPhone>
{
    public override void Configure(EntityTypeBuilder<RefPhone> builder)
    {
        base.Configure(builder);

        builder.OwnsOne(typeof(Phone), "Phone");

        builder.HasOne(e => e.Customer)
            .WithOne(e => e.Phone)
            .HasForeignKey<Customer>(e => e.PhoneId)
            .IsRequired();
    }
}
