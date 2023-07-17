using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.CustomerManagement;

public class PhoneMap : BaseEntityMap<RefPhone>
{
    public override void Configure(EntityTypeBuilder<RefPhone> builder)
    {
        base.Configure(builder);


    }
}
