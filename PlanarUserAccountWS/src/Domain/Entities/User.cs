namespace PlanarUserAccountWS.src.Domain;

public class User : BaseEntity
{
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public ICollection<UserRole> Roles { get; private set; }
    public ICollection<UserClaim> Claims { get; private set; }

    public User(
        string userName,
        string email,
        ICollection<UserRole> roles,
        ICollection<UserClaim> claims
        )
    {
        UserName = userName;
        Email = email;
        Roles = roles;
        Claims = claims;
    }
}