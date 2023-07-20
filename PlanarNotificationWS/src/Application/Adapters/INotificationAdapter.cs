using MongoDB.Bson;

namespace PlanarNotificationWS.src.Application;

public interface INotificationAdapter
{
    Task SaveNotification(NotificationRegistrationDTO notification);
    Task<ICollection<ReplyNotificationDTO>> FindNotifications();
    Task UpdateNotification(NotificationRegistrationDTO notification);
    Task SaveUser(UserRegistrationDTO user);
    Task UpdateUser(UserRegistrationDTO user);
}