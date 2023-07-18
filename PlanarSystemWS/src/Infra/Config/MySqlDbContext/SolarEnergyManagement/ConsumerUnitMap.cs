using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.SolarEnergyManagement;

public class ConsumerUnitMap : BaseEntityMap<ConsumerUnit>
{
    public override void Configure(EntityTypeBuilder<ConsumerUnit> builder)
    {
        base.Configure(builder);

        builder.ToTable("consumer_units");

        builder.Property(x => x.Reference)
            .HasColumnName("reference");

        builder.Property(x => x.NetworkType)
            .HasColumnName("network_type");

        builder.Property(x => x.MonthlyConsumption)
            .HasColumnName("monthly_consumption");

        builder.Property(x => x.UnitPrice)
            .HasColumnName("unit_price");

        builder.Property(x => x.BudgetFormId)
            .HasColumnName("budget_form_id");
    }
}
