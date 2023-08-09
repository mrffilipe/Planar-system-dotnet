using AutoMapper;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Application;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<DetailedUserCreatedEvent, User>()
            .ConstructUsing(s => new User(
                s.UserAccountId,
                s.FirstName,
                s.LastName,
                s.Email
                )
            );

        CreateMap<User, CustomIdentityUser>()
            .ConstructUsing(s => new CustomIdentityUser(
                s.UserAccountId,
                s.FirstName,
                s.LastName,
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