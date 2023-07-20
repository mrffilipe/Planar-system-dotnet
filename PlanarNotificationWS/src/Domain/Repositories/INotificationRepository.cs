﻿using MongoDB.Bson;

namespace PlanarNotificationWS.src.Domain;

public interface INotificationRepository
{
    Task SaveNotification(Notification notification);
    Task<ICollection<Notification>> FindNotificationsByUserId(ObjectId id);
    Task UpdateNotification(Notification notification);
    Task SaveUser(User user);
    Task UpdateUser(User user);
}