namespace PlanarUserAccountWS.src.Domain;

public class User : BaseEntity
{
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public User(string userName, string email)
    {
        UserName = userName;
        Email = email;
    }
}