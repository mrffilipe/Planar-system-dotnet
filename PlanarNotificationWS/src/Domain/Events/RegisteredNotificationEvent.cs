namespace PlanarNotificationWS.src.Domain;

public class RegisteredNotificationEvent : IEvent
{
    public NotificationRelationship Relationship { get; set; }
    public string Text { get; set; }
    public string UserAccountId { get; set; }
    public string Queue => "new-registered-user";
    public string Exchange => "ex";
    public string RoutingKey => "";
}