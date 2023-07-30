namespace PlanarAuthenticationWS.src.Domain;

public class User : BaseEntity
{
    public string UserName { get; private set; }
    public string Email { get; private set; }

    public User(
        string userAccountid,
        string userName,
        string email
        )
    {
        UserAccountId = userAccountid;
        UserName = userName;
        Email = email;
    }
}