namespace PlanarUserAccountWS.src.Domain;

public class RefUserClaim : BaseEntity
{
    public UserClaim UserClaim { get; private set; }
    public Guid UserId { get; private set; }
    public User User { get; private set; }

    private RefUserClaim()
    {
    }

    public RefUserClaim(UserClaim userClaim, User user)
    {
        UserClaim = userClaim;
        User = user;
    }
}