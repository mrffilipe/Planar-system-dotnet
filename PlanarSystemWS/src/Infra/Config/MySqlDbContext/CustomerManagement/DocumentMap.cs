using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.CustomerManagement;

public class DocumentMap : IEntityTypeConfiguration<RefDocument>
{
    public void Configure(EntityTypeBuilder<RefDocument> builder)
    {
        throw new NotImplementedException();
    }
}
