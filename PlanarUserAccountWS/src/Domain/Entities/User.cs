using System.Collections.ObjectModel;

namespace PlanarUserAccountWS.src.Domain;

public class User : BaseEntity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public ICollection<RefUserRole> Roles { get; private set; }
    public ICollection<RefUserClaim> Claims { get; private set; }

    public User(
        string firstName,
        string lastName,
        string email
        )
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Roles = new Collection<RefUserRole>();
        Claims = new Collection<RefUserClaim>();
    }

    public User(
        string firstName,
        string lastName,
        string email,
        ICollection<RefUserRole> roles,
        ICollection<RefUserClaim> claims
        ) : this(firstName, lastName, email)
    {
        Roles = roles;
        Claims = claims;
    }
}