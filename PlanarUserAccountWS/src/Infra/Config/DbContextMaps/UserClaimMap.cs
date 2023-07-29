using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Infra;

public class UserClaimMap : BaseEntityMap<RefUserClaim>
{
    public override void Configure(EntityTypeBuilder<RefUserClaim> builder)
    {
        base.Configure(builder);

        builder.ToTable("user_claims");

        builder.OwnsOne(p => p.UserClaim, uc =>
        {
            uc.Property(x => x.Type)
            .HasColumnName("type");

            uc.Property(x => x.Value)
            .HasColumnName("value");
        });

        builder.Property(x => x.UserId)
            .HasColumnName("user_id");
    }
}
