using System.Collections.ObjectModel;

namespace PlanarAuthenticationWS.src.Domain;

public class DetailedUserCreatedEvent : IEvent
{
    public Guid UserAccountId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    //public ICollection<RefUserRole> Roles { get; private set; }
    //public ICollection<RefUserClaim> Claims { get; private set; }
    public ICollection<EventConfiguration> Configurations => new Collection<EventConfiguration>()
    {
        new EventConfiguration("user-events_auth_service", "user-events", "user.detailed-user-created"),

    };

    public DetailedUserCreatedEvent(
       Guid userAccountId,
       string firstName,
       string lastName,
       string email
       )
    {
        UserAccountId = userAccountId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        //Roles = new Collection<RefUserRole>();
        //Claims = new Collection<RefUserClaim>();
    }

    //public DetailedUserCreatedEvent(
    //    string userAccountId,
    //    string firstName,
    //    string lastName,
    //    string email,
    //    ICollection<RefUserRole> roles,
    //    ICollection<RefUserClaim> claims
    //    ) : this(userAccountId, firstName, lastName, email)
    //{
    //    Roles = roles;
    //    Claims = claims;
    //}
}