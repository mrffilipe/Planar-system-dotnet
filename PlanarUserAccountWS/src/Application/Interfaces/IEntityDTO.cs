using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PlanarUserAccountWS.src.Application;

public interface IEntityDTO
{
    [BsonId]
    public ObjectId Id { get; }
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime CreatedOn { get; }
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime UpdatedOn { get; }
}