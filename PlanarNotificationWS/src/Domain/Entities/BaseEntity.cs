using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PlanarNotificationWS.src.Domain;

public abstract class BaseEntity : IEntity<ObjectId>
{
    [BsonId]
    public ObjectId Id { get; private set; }
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime CreatedOn { get; private set; }
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime UpdatedOn { get; private set; }
}