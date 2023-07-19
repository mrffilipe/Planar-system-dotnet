using AutoMapper;
using PlanarChatMessagingWS.src.Domain;

namespace PlanarChatMessagingWS.src.Application;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserRegistrationDTO, User>();
        CreateMap<User, ReplyUserDTO>();
    }
}