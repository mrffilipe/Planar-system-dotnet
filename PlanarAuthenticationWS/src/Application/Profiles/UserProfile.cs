using AutoMapper;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Application;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisteredUserEvent, User>()
            .ConstructUsing(s => new User(
                s.UserAccountId,
                s.UserName,
                s.Email
                )
            );

        CreateMap<User, CustomIdentityUser>()
            .ConstructUsing(s => new CustomIdentityUser(
                s.UserAccountId,
                s.UserName,
                s.Email
                )
            );
    }
}