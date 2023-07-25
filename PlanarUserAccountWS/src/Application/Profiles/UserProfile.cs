using AutoMapper;
using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Application;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserRegistrationDTO, User>();
        CreateMap<User, ReplyUserDTO>();

        CreateMap<User, RegisteredUserEvent>();
    }
}