using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.SalesManagement;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.UserManagement;

public class UserMap : BaseEntityMap<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);

        builder.ToTable("users");

        builder.Property(x => x.UserName)
            .HasColumnName("username");

        builder.Property(x => x.Email)
            .HasColumnName("email");

        builder.HasOne(e => e.Seller)
            .WithOne(e => e.User)
            .HasForeignKey<Seller>(e => e.UserId)
            .IsRequired();
    }
}
