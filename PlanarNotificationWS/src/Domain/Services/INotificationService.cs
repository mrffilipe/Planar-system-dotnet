namespace PlanarNotificationWS.src.Domain;

public interface INotificationService
{
    void Save(Notification notification);
    Notification FindById(string id);
    void Update(Notification notification);
}