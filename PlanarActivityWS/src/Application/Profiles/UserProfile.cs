using AutoMapper;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

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

        CreateMap<UpdatedUserEvent, User>()
            .ConstructUsing(source => new User(
                source.UserAccountId,
                source.FirstName,
                source.LastName
                )
            );
    }
}