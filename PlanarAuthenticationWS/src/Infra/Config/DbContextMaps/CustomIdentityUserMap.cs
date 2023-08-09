using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Infra;

public class CustomIdentityUserMap : IdentityUserMap<CustomIdentityUser>
{
    public override void Configure(EntityTypeBuilder<CustomIdentityUser> builder)
    {
        base.Configure(builder);

        //builder.HasKey(x => x.Id);

        //builder.Property(x => x.Id)
        //    .ValueGeneratedOnAdd();

        builder.HasIndex(x => x.UserAccountId)
            .HasDatabaseName("UserAccountIdIndex")
            .IsUnique();

        builder.HasIndex(x => x.NormalizedUserName)
            .IsUnique();

        builder.HasIndex(x => x.NormalizedEmail)
            .IsUnique();

        builder.Property(x => x.NormalizedUserName)
            .IsRequired();

        builder.Property(x => x.NormalizedEmail)
            .IsRequired();
    }
}