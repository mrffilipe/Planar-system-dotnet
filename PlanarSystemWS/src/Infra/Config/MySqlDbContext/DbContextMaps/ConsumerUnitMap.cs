using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

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