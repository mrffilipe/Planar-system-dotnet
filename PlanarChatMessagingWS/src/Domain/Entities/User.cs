namespace PlanarChatMessagingWS.src.Domain;

public class User : BaseEntity
{
    public string UserName { get; private set; }
    public string Email { get; private set; }

    private User()
    {
    }

    public User(string userName, string email)
    {
        UserName = userName;
        Email = email;
    }
}