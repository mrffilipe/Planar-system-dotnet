using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.CustomerManagement;

public class CustomerMap : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        throw new NotImplementedException();
    }
}
