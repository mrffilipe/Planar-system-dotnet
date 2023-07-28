namespace PlanarNotificationWS.src.Domain;

public interface INotificationRepository
{
    Task SaveNotification(Notification notification);
    Task<IList<Notification>> FindNotificationsByUserId(string userAccountId);
    Task UpdateNotification(Notification notification);
    Task SaveUser(User user);
    Task UpdateUser(User user);
}