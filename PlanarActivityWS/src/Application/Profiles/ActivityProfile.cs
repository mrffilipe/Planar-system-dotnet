using AutoMapper;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

public class ActivityProfile : Profile
{
    public ActivityProfile()
    {
        CreateMap<ActivityRegistrationDTO, Activity>();
        CreateMap<Activity, ReplyActivityDTO>();
    }
}