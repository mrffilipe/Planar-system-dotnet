using AutoMapper;
using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Application;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisterUserDTO, User>();
        CreateMap<User, ReplyUserDTO>();
        CreateMap<UpdateUserDTO, User>();

        CreateMap<User, RegisteredUserEvent>();
    }
}