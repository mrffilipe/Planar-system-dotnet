namespace PlanarAuthenticationWS.src.Domain;

public class CustomIdentityUser : BaseIdentityUser
{
    public override string UserAccountId { get; protected set; }

    public CustomIdentityUser(
        string userAccountId,
        string userName,
        string email
        )
    {
        UserAccountId = userAccountId;
        UserName = userName;
        Email = email;
    }
}