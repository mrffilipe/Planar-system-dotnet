using AutoMapper;
using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Application;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterUserDTO, User>()
            .ConstructUsing(s => new User(
                s.FirstName,
                s.LastName,
                s.Email
                )
            );

        CreateMap<User, ReplyUserDTO>();

        CreateMap<UpdateUserDTO, User>()
            .ConstructUsing(s => new User(
                s.Id,
                s.FirstName,
                s.LastName,
                s.Email
                )
            );

        CreateMap<User, RegisteredUserEvent>()
            .ConstructUsing(s => new RegisteredUserEvent(
                s.Id.ToString(),
                s.FirstName,
                s.LastName,
                s.Email,
                s.Roles,
                s.Claims
                )
            );
    }
}