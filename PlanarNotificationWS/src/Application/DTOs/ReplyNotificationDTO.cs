using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class ReplyNotificationDTO
{
    [BsonId]
    public ObjectId UserId { get; set; }
    public NotificationRelationship Relationship { get; set; }
    public string Text { get; set; }
    public bool Read { get; set; }
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime DateRead { get; set; }
}