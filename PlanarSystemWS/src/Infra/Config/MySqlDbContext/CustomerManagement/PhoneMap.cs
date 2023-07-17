using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.CustomerManagement;

public class PhoneMap : IEntityTypeConfiguration<RefPhone>
{
    public void Configure(EntityTypeBuilder<RefPhone> builder)
    {
        throw new NotImplementedException();
    }
}
