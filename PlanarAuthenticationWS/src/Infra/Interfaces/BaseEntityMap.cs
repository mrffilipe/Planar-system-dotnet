using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Infra;

public abstract class IdentityUserMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : IdentityUser<Guid>
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        //builder.HasKey(x => x.Id);

        //builder.Property(x => x.Id)
        //    .ValueGeneratedOnAdd();

        //builder.HasIndex(x => x.UserAccountId)
        //    .HasDatabaseName("UserAccountIdIndex")
        //    .IsUnique();

        //builder.HasIndex(x => x.NormalizedUserName)
        //    .IsUnique();

        //builder.HasIndex(x => x.NormalizedEmail)
        //    .IsUnique();

        //builder.Property(x => x.NormalizedUserName)
        //    .IsRequired();

        //builder.Property(x => x.NormalizedEmail)
        //    .IsRequired();

        //builder.Property(x => x.UserAccountId);

        //builder.Property(x => x.CreatedOn);

        //builder.Property(x => x.UpdatedOn);
    }
}