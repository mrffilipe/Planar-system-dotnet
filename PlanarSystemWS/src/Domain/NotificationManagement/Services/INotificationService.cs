namespace PlanarSystemWS.src.Domain.NotificationManagement;

public interface INotificationService
{
    void Save(Notification notification);
    Notification FindById(string id);
    void Update(Notification notification);
}
