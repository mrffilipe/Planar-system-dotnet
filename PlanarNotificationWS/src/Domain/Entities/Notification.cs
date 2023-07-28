using MongoDB.Bson.Serialization.Attributes;

namespace PlanarNotificationWS.src.Domain;

public class Notification : BaseEntity
{
    public NotificationRelationship Relationship { get; private set; }
    public string Text { get; private set; }
    public bool Read { get; private set; }
    [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
    public DateTime DateRead { get; private set; }
    public string UserAccountId { get; private set; }

    public Notification(
        NotificationRelationship relationship,
        string text,
        string userAccountId
        //bool read,
        //DateTime dateRead
        )
    {
        Relationship = relationship;
        Text = text;
        UserAccountId = userAccountId;
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