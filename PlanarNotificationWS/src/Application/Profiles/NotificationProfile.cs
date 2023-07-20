using AutoMapper;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class NotificationProfile : Profile
{
    public NotificationProfile()
    {
        CreateMap<NotificationRegistrationDTO, Notification>();
        CreateMap<Notification, ReplyNotificationDTO>();
    }
}