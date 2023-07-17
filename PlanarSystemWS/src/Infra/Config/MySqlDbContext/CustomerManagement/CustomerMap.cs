using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.CustomerManagement;

public class CustomerMap : BaseEntityMap<Customer>
{
    public override void Configure(EntityTypeBuilder<Customer> builder)
    {
        base.Configure(builder);

        
    }
}
