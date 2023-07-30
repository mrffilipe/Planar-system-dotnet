using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Infra;

public abstract class BaseIdentityUserMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseIdentityUser
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasIndex(x => x.UserAccountId)
            .HasDatabaseName("UserAccountIdIndex")
            .IsUnique();

        builder.HasIndex(x => x.NormalizedEmail)
            .IsUnique();

        builder.Property(x => x.UserAccountId)
            .IsRequired();

        builder.Property(x => x.CreatedOn)
            .IsRequired();

        builder.Property(x => x.UpdatedOn)
            .IsRequired();

        builder.Property(x => x.NormalizedUserName)
            .IsRequired();

        builder.Property(x => x.NormalizedEmail)
            .IsRequired();
    }
}