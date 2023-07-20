using MongoDB.Bson;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class NotificationService : INotificationService
{
    private readonly INotificationRepository _notificationRepository;

    public NotificationService(INotificationRepository notificationRepository)
    {
        _notificationRepository = notificationRepository;
    }

    public Task SaveNotification(Notification notification)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Notification>> FindNotificationsByUserId()
    {
        throw new NotImplementedException();
    }

    public Task UpdateNotification(Notification notification)
    {
        throw new NotImplementedException();
    }

    public Task SaveUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}