using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.SalesManagement;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.SalesManagement;

public class SellerMap : BaseEntityMap<Seller>
{
    public override void Configure(EntityTypeBuilder<Seller> builder)
    {
        base.Configure(builder);

        builder.ToTable("sellers");

        builder.Property(x => x.SalesCommission)
            .HasColumnName("sales_commission");

        builder.Property(x => x.UserId)
            .HasColumnName("user_id");

        builder.HasOne(e => e.BudgetForm)
            .WithOne(e => e.Seller)
            .HasForeignKey<RefBudgetForm>(e => e.SellerId)
            .IsRequired();
    }
}
