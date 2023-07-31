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
                s.UserName, // verififcar username
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

        CreateMap<SignInUserDTO, SignInUser>()
            .ConstructUsing(s => new SignInUser(
                s.UserName,
                s.Password
                )
            );

        CreateMap<SignInUserResult, SignInUserResultDTO>()
            .ConstructUsing(s => new SignInUserResultDTO(
                s.UserName,
                s.Token
                )
            );
    }
}