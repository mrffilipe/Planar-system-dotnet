using MongoDB.Bson;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Infra;

public class NotificationRepository : INotificationRepository
{
    // ...

    public Task SaveNotification(Notification notification)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Notification>> FindNotificationsByUserId(ObjectId userId)
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