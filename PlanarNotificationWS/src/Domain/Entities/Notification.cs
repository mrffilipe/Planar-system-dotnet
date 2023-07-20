using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PlanarNotificationWS.src.Domain;

public class Notification : BaseEntity
{
    public ObjectId UserId { get; private set; }
    public NotificationRelationship Relationship { get; private set; }
    public string Text { get; private set; }
    public bool Read { get; private set; }
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime DateRead { get; private set; }

    public Notification(
        ObjectId userId,
        NotificationRelationship relationship,
        string text
        //bool read,
        //DateTime dateRead
        )
    {
        UserId = userId;
        Relationship = relationship;
        Text = text;
        //Read = read;
        //DateRead = dateRead;
    }

    public void ConfirmRead()
    {
        if (!Read)
        {
            Read = true;
            ChangeDateRead();
        }
    }

    private void ChangeDateRead()
    {
        DateRead = DateTime.UtcNow;
    }
}