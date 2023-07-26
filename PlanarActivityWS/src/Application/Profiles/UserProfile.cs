using AutoMapper;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserRegistrationDTO, User>();

        CreateMap<RegisteredUserEvent, User>()
            .ConstructUsing(source => new User(source.UserName, source.Email));
    }
}