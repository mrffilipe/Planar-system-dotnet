using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class ReplyNotificationDTO : IEntityDTO
{
    public string Id { get; set; }
    public NotificationRelationship Relationship { get; set; }
    public string Text { get; set; }
    public bool Read { get; set; }
    public DateTime DateRead { get; set; }
    public string UserAccountId { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}