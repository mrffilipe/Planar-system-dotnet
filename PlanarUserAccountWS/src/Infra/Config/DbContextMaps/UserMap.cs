using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Infra;

public class UserMap : BaseEntityMap<User>
{
    public override void Configure(EntityTypeBuilder<User> builder)
    {
        base.Configure(builder);

        builder.ToTable("users");

        builder.HasIndex(x=>x.Email)
            .IsUnique();

        builder.Property(x => x.FirstName)
            .HasColumnName("first_name");

        builder.Property(x => x.LastName)
            .HasColumnName("last_name");

        builder.Property(x => x.Email)
            .HasColumnName("email");

        builder.HasMany(x => x.Claims)
             .WithOne(x => x.User)
             .HasForeignKey(x => x.UserId)
             .IsRequired();
    }
}
