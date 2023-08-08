using PlanarSystemWS.src.Domain.Shared;

namespace PlanarSystemWS.src.Domain.UserManagement;

public class RegisteredUserEvent : IEvent
{
    public string UserAccountId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Queue => "new-registered-user";
    public string Exchange => "ex";
    public string RoutingKey => "";

    public RegisteredUserEvent(
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