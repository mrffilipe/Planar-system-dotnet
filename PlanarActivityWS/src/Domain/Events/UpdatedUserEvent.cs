namespace PlanarActivityWS.src.Domain;

public class UpdatedUserEvent : IEvent
{
    public string UserAccountId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Queue => "updated-user";
    public string Exchange => "ex";
    public string RoutingKey => "";

    public UpdatedUserEvent(
        string userAccountId,
        string firstName,
        string lastName
        )
    {
        UserAccountId = userAccountId;
        FirstName = firstName;
        LastName = lastName;
    }
}