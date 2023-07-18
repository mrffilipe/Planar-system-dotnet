using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.SolarEnergyManagement;

public class RefBudgetFormMap : BaseEntityMap<RefBudgetForm>
{
    public override void Configure(EntityTypeBuilder<RefBudgetForm> builder)
    {
        base.Configure(builder);

        builder.OwnsOne(typeof(BudgetForm), "BudgetForm");

        builder.HasMany(e => e.ConsumerUnits)
            .WithOne(e => e.BudgetForm)
            .HasForeignKey(e => e.BudgetFormId)
            .IsRequired();

    }
}
