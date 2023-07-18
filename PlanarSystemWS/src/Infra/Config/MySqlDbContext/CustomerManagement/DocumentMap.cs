using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Infra.Config.MySqlDbContext.CustomerManagement;

public class DocumentMap : BaseEntityMap<RefDocument>
{
    public override void Configure(EntityTypeBuilder<RefDocument> builder)
    {
        base.Configure(builder);

        builder.ToTable("documents");

        builder.OwnsOne(e => e.Document, doc =>
        {
            doc.Property(x => x.Type)
                .HasColumnName("type");

            doc.Property(x => x.Reference)
                .HasColumnName("reference");
        });

        builder.HasOne(e => e.Customer)
        .WithOne(e => e.Document)
        .HasForeignKey<Customer>(e => e.DocumentId)
        .IsRequired();
    }
}