using AutoMapper;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<RegisteredUserEvent, User>()
            .ConstructUsing(source => new User(
                source.UserAccountId,
                source.FirstName,
                source.LastName,
                source.Email,
                source.Phone
                )
            );
    }
}