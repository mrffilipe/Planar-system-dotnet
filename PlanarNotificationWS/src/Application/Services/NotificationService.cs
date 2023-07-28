using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class NotificationService : INotificationService
{
    private readonly INotificationRepository _notificationRepository;

    public NotificationService(INotificationRepository notificationRepository)
    {
        _notificationRepository = notificationRepository;
    }

    public async Task SaveNotification(Notification notification)
    {
        try
        {
            await _notificationRepository.SaveNotification(notification);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<IList<Notification>> FindNotificationsByUserId()
    {
        try
        {
            var notifications = await _notificationRepository.FindNotificationsByUserId(""); // passar id do identity

            return notifications;
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateNotification(Notification notification)
    {
        try
        {
            await _notificationRepository.UpdateNotification(notification);
        }
        catch (Exception ex) { throw; }
    }

    public async Task SaveUser(User user)
    {
        try
        {
            await _notificationRepository.SaveUser(user);
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateUser(User user)
    {
        try
        {
            await _notificationRepository.UpdateUser(user);
        }
        catch (Exception ex) { throw; }
    }
}