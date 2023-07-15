namespace PlanarSystemWS.src.Domain.NotificationManagement;

public interface INotificationRepository
{
    void Save(Notification notification);
    Notification FindById(string id);
    void Update(Notification notification);
}
