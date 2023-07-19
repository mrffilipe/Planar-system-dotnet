namespace PlanarNotificationWS.src.Domain;

public interface INotificationRepository
{
    void Save(Notification notification);
    Notification FindById(string id);
    void Update(Notification notification);
}