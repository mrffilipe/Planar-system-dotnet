using MongoDB.Bson;

namespace PlanarChatMessagingWS.src.Domain;

public abstract class BaseEntity : IEntity<ObjectId>
{
    public ObjectId Id { get; private set; }

    public DateTime CreatedOn { get; private set; }

    public DateTime UpdatedOn { get; private set; }
}