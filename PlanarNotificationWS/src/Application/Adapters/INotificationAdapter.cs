using MongoDB.Bson;

namespace PlanarNotificationWS.src.Application;

public interface INotificationAdapter
{
    Task SaveNotification(NotificationRegistrationDTO notification);
    Task<ICollection<ReplyNotificationDTO>> FindNotificationsByUserId(ObjectId id);
    Task UpdateNotification(NotificationRegistrationDTO notification);
    Task SaveUser(UserRegistrationDTO user);
    Task UpdateUser(UserRegistrationDTO user);
}