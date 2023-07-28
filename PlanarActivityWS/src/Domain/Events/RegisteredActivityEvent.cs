namespace PlanarActivityWS.src.Domain;

public class RegisteredActivityEvent : IEvent
{
    public ActivityRelationship Relationship { get; private set; }
    public ActivityStatus Status { get; private set; }
    public string UserAccountId { get; private set; }
    public string Queue => "new-registered-activity";
    public string Exchange => "ex";
    public string RoutingKey => "";

    public RegisteredActivityEvent(
        ActivityRelationship relationship,
        ActivityStatus status,
        string userAccountId
        )
    {
        Relationship = relationship;
        Status = status;
        UserAccountId = userAccountId;
    }
}