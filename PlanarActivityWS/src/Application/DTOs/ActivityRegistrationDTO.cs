using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

public class ActivityRegistrationDTO
{
    [BsonId]
    public ObjectId UserId { get; set; }
    public ActivityRelationship Relationship { get; set; }
    public ActivityStatus Status { get; set; }
}