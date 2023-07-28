using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class UpdateNotificationDTO
{
    public NotificationRelationship Relationship { get; set; }
    public string Text { get; set; }
    //public bool Read { get; private set; }
    //public DateTime DateRead { get; private set; }
    public string UserAccountId { get; set; }
}