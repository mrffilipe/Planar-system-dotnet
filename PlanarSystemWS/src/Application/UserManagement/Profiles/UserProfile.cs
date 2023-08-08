using AutoMapper;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Application.UserManagement;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisteredUserEvent, User>()
            .ConstructUsing(source => new User(
                source.UserAccountId,
                source.FirstName,
                source.LastName
                )
            );

        CreateMap<User, ReplyUserDTO>();
    }
}
