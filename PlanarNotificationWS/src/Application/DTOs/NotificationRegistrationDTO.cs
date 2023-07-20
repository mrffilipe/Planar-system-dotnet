using MongoDB.Bson;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class NotificationRegistrationDTO
{
    public ObjectId UserId { get; set; }
    public NotificationRelationship Relationship { get; set; }
    public string Text { get; set; }
    public bool Read { get; set; }
}