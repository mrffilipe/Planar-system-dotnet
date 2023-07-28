namespace PlanarNotificationWS.src.Application;

public interface INotificationAdapter
{
    Task<IList<ReplyNotificationDTO>> FindNotifications();
    Task UpdateNotification(UpdateNotificationDTO notification);
}