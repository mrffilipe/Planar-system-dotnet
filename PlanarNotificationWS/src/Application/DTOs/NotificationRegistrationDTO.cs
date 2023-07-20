using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class NotificationRegistrationDTO
{
    [BsonId]
    public ObjectId UserId { get; set; }
    public NotificationRelationship Relationship { get; set; }
    public string Text { get; set; }
}