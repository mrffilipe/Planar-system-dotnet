using AutoMapper;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class NotificationProfile : Profile
{
    public NotificationProfile()
    {
        CreateMap<Notification, ReplyNotificationDTO>();
        CreateMap<UpdateNotificationDTO, Notification>()
            .ConstructUsing(source => new Notification(
                source.Relationship,
                source.Text,
                source.UserAccountId
                )
            );

        CreateMap<RegisteredNotificationEvent, Notification>()
            .ConstructUsing(source => new Notification(
                source.Relationship,
                source.Text,
                source.UserAccountId
                )
            );
    }
}