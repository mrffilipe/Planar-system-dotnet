using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

public class SellerMap : BaseEntityMap<Seller>
{
    public override void Configure(EntityTypeBuilder<Seller> builder)
    {
        base.Configure(builder);

        builder.ToTable("sellers");

        builder.HasIndex(x => x.UserAccountId)
            .IsUnique();

        builder.Property(x => x.UserAccountId)
            .HasColumnName("user_account_id");

        builder.Property(x => x.FirstName)
            .HasColumnName("first_name");

        builder.Property(x => x.LastName)
            .HasColumnName("last_name");

        builder.Property(x => x.SalesCommission)
            .HasColumnName("sales_commission");
    }
}