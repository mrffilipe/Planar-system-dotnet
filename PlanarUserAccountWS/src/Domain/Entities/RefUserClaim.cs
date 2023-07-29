namespace PlanarUserAccountWS.src.Domain;

public class RefUserClaim : BaseEntity
{
    public UserClaim UserClaim { get; private set; }
    public Guid UserId { get; private set; }
    public User User { get; private set; }

    private RefUserClaim()
    {
    }

    public RefUserClaim(UserClaim userClaim)
    {
        UserClaim = userClaim;
    }

    public RefUserClaim(Guid id, UserClaim userClaim) : this(userClaim)
    {
        Id = id;
    }

    public RefUserClaim(UserClaim userClaim, Guid userId) : this(userClaim)
    {
        UserId = userId;
    }

    public RefUserClaim(Guid id, UserClaim userClaim, Guid userId) : this(userClaim, userId)
    {
        Id = id;
    }
}