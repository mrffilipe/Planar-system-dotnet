using AutoMapper;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserRegistrationDTO, User>();
    }
}