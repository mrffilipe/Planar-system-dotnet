using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.AddressManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.AddressManagement;

public class AddressMap : BaseEntityMap<RefAddress>
{
    public override void Configure(EntityTypeBuilder<RefAddress> builder)
    {
        base.Configure(builder);


    }
}
