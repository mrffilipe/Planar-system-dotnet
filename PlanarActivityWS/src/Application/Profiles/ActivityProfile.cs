using AutoMapper;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

public class ActivityProfile : Profile
{
    public ActivityProfile()
    {
        CreateMap<Activity, ReplyActivityDTO>();

        CreateMap<RegisteredActivityEvent, Activity>()
            .ConstructUsing(source => new Activity(
                source.Relationship,
                source.Status,
                source.UserAccountId
            )
        );

        CreateMap<UpdatedActivityEvent, Activity>()
            .ConstructUsing(source => new Activity(
                source.Relationship,
                source.Status,
                source.UserAccountId
            )
        );
    }
}