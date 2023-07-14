using PlanarSystemWS.src.Domain.shared;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Domain.ActivityManagement;

public class Activity : BaseEntity
{
    public User User { get; set; }
    public ActivityType Type { get; set; }
    public string RelationshipId { get; set; }
    public ActivityStatus Status { get; set; }

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