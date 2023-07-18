using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.SolarEnergyManagement;

public class RefBudgetFormMap : BaseEntityMap<RefBudgetForm>
{
    public override void Configure(EntityTypeBuilder<RefBudgetForm> builder)
    {
        base.Configure(builder);

        builder.ToTable("budget_forms");

        builder.OwnsOne(e => e.BudgetForm, bf =>
        {
            bf.Property(x => x.ExtraProduction)
                .HasColumnName("extra_production");

            bf.Property(x => x.Observation)
                .HasColumnName("observation");

            bf.Property(x => x.Transformer)
                .HasColumnName("transformer");
        });

        builder.Property(x => x.SellerId)
            .HasColumnName("seller_id");

        builder.Property(x => x.CustomerId)
            .HasColumnName("customer_id");

        builder.Property(x => x.InstallationAddressId)
            .HasColumnName("installation_address_id");

        builder.HasMany(e => e.ConsumerUnits)
            .WithOne(e => e.BudgetForm)
            .HasForeignKey(e => e.BudgetFormId)
            .IsRequired();
    }
}
