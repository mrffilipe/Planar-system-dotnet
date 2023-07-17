using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.AddressManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.AddressManagement;

public class AddressMap : IEntityTypeConfiguration<RefAddress>
{
    public void Configure(EntityTypeBuilder<RefAddress> builder)
    {
        throw new NotImplementedException();
    }
}
