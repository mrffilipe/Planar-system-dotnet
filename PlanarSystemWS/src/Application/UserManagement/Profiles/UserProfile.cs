using AutoMapper;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Application.UserManagement;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserRegistrationDTO, User>();
        CreateMap<User, ReplyUserDTO>();
    }
}
