using PlanarSystemWS.src.Domain.shared;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Domain.NotificationManagement;

public class Notification : BaseEntity
{
    public User User { get; private set; }
    public NotificationType Type { get; private set; }
    public string RelationshipId { get; private set; }
    public string Text { get; private set; }
    public bool Read { get; private set; }
    public DateTime DateRead { get; private set; }

    public Notification(
        User user,
        NotificationType type,
        string relationshipId,
        string text,
        bool read,
        DateTime dateRead
        )
    {
        User = user;
        Type = type;
        RelationshipId = relationshipId;
        Text = text;
        Read = read;
        DateRead = dateRead;
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