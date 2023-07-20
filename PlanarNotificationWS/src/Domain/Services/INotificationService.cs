using MongoDB.Bson;

namespace PlanarNotificationWS.src.Domain;

public interface INotificationService
{
    Task SaveNotification(Notification notification);
    Task<ICollection<Notification>> FindNotificationsByUserId();
    Task UpdateNotification(Notification notification);
    Task SaveUser(User user);
    Task UpdateUser(User user);
}