using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

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