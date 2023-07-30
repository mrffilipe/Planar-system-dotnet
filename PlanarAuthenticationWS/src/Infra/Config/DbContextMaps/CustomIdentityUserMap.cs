using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Infra;

public class CustomIdentityUserMap : BaseIdentityUserMap<CustomIdentityUser>
{
    public override void Configure(EntityTypeBuilder<CustomIdentityUser> builder)
    {
        base.Configure(builder);
    }
}