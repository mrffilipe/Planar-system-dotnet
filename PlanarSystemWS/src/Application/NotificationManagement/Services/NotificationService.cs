using PlanarSystemWS.src.Domain.NotificationManagement;

namespace PlanarSystemWS.src.Application.NotificationManagement;

public class NotificationService : INotificationService
{
    private readonly INotificationRepository _notificationRepository;

    public NotificationService(INotificationRepository notificationRepository)
    {
        _notificationRepository = notificationRepository;
    }

    public void Save(Notification notification)
    {
        throw new NotImplementedException();
    }

    public Notification FindById(string id)
    {
        throw new NotImplementedException();
    }

    public void Update(Notification notification)
    {
        throw new NotImplementedException();
    }
}