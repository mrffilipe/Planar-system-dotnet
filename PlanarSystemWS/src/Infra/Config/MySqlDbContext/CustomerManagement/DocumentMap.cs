using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.CustomerManagement;

public class DocumentMap : BaseEntityMap<RefDocument>
{
    public override void Configure(EntityTypeBuilder<RefDocument> builder)
    {
        base.Configure(builder);


    }
}
