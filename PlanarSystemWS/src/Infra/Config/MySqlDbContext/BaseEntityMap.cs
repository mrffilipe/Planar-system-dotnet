using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.Shared;

namespace PlanarSystemWS.src.Infra;

public abstract class BaseEntityMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
{
    public virtual void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .HasColumnName("id")
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.CreatedOn)
            .HasColumnName("created_on")
            .IsRequired();

        builder.Property(x => x.UpdatedOn)
            .HasColumnName("updated_on")
            .IsRequired();
    }
}