namespace PlanarNotificationWS.src.Domain;

public class User : BaseEntity
{
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public Phone Phone { get; private set; }
    public User(string userName, string email, Phone phone)
    {
        UserName = userName;
        Email = email;
        Phone = phone;
    }
}