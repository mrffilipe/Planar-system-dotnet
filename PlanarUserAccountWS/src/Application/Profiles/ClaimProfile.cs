using AutoMapper;
using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Application;

public class ClaimProfile : Profile
{
    public ClaimProfile()
    {
        CreateMap<AddMinimumClaimDTO, RefUserClaim>()
            .ConstructUsing(s => new RefUserClaim(s.UserClaim));

        CreateMap<RefUserClaim, ReplyClaimDTO>();

        CreateMap<AddClaimDTO, RefUserClaim>()
            .ConstructUsing(s => new RefUserClaim(
                s.UserClaim,
                s.UserId
                )
            );

        CreateMap<UpdateClaimDTO, RefUserClaim>()
            .ConstructUsing(s => new RefUserClaim(
                s.Id,
                s.UserClaim,
                s.Userid
                )
            );

        CreateMap<RemoveClaimDTO, RefUserClaim>()
            .ConstructUsing(s => new RefUserClaim(
                s.Id,
                s.UserClaim
                )
            );
    }
}