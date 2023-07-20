namespace PlanarActivityWS.src.Domain;

public class Activity : BaseEntity
{
    public User User { get; private set; }
    public ActivityType Type { get; private set; }
    public string RelationshipId { get; private set; }
    public ActivityStatus Status { get; private set; }

    public Activity(
        User user,
        ActivityType type,
        string relationshipId,
        ActivityStatus status
        )
    {
        User = user;
        Type = type;
        RelationshipId = relationshipId;
        Status = status;
    }

    public void ChangeStatus(ActivityStatus status)
    {
        if (status != Status) Status = status;
    }
}