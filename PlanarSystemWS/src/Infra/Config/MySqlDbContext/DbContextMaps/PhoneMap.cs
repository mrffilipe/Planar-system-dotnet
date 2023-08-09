using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

public class PhoneMap : BaseEntityMap<RefPhone>
{
    public override void Configure(EntityTypeBuilder<RefPhone> builder)
    {
        base.Configure(builder);

        builder.ToTable("phones");

        builder.Property(x => x.IsWhatsapp)
            .HasColumnName("is_whatsapp");

        builder.OwnsOne(e => e.Phone, phone =>
        {
            phone.Property(x => x.CountryCode)
                .HasColumnName("country_code");

            phone.Property(x => x.DDD)
                .HasColumnName("ddd");

            phone.Property(x => x.Number)
                .HasColumnName("number");
        });

        builder.HasOne(e => e.Customer)
            .WithOne(e => e.Phone)
            .HasForeignKey<Customer>(e => e.PhoneId)
            .IsRequired();
    }
}