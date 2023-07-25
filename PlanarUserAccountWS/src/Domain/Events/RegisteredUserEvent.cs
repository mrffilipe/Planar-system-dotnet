namespace PlanarUserAccountWS.src.Domain;

public class RegisteredUserEvent : BaseEvent
{
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public ICollection<UserRole> Roles { get; private set; }
    public ICollection<UserClaim> Claims { get; private set; }
    public override string Queue { get; protected set; } = "new-registered-user";
    public override string Exchange { get; protected set; } = "ex";
    public override string RoutingKey { get; protected set; } = "";

    protected RegisteredUserEvent(
        string userName,
        string email,
        ICollection<UserRole> roles,
        ICollection<UserClaim> claims)
    {
        UserName = userName;
        Email = email;
        Roles = roles;
        Claims = claims;
    }
}