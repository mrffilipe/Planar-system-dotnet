using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PlanarAuthenticationWS.src.Infra;

public abstract class IdentityUserMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : IdentityUser<Guid>
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
    }
}