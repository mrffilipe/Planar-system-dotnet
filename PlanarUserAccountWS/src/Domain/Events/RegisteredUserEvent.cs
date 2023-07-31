using System.Collections.ObjectModel;

namespace PlanarUserAccountWS.src.Domain;

public class RegisteredUserEvent : IEvent
{
    public string UserAccountId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public ICollection<RefUserRole> Roles { get; private set; }
    public ICollection<RefUserClaim> Claims { get; private set; }
    public string Queue => "new-registered-user";
    public string Exchange => "ex";
    public string RoutingKey => "";

    public RegisteredUserEvent(
       string userAccountId,
       string firstName,
       string lastName,
       string email
       )
    {
        UserAccountId = userAccountId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Roles = new Collection<RefUserRole>();
        Claims = new Collection<RefUserClaim>();
    }

    public RegisteredUserEvent(
        string userAccountId,
        string firstName,
        string lastName,
        string email,
        ICollection<RefUserRole> roles,
        ICollection<RefUserClaim> claims
        ) : this(userAccountId, firstName, lastName, email)
    {
        Roles = roles;
        Claims = claims;
    }
}