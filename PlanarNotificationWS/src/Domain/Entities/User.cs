namespace PlanarNotificationWS.src.Domain;

public class User : BaseEntity
{
    public string UserAccountId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public Phone Phone { get; private set; }
    public IList<Notification> Notifications { get; private set; }

    public User(
        string userAccountId,
        string firstName,
        string lastName,
        string email,
        Phone phone
        )
    {
        UserAccountId = userAccountId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Phone = phone;
        Notifications = new List<Notification>();
    }

    public User(
        string userAccountId,
        string firstName,
        string lastName,
        string email,
        Phone phone,
        IList<Notification> notifications
        ) : this(userAccountId, firstName, lastName, email, phone)
    {
        Notifications = notifications;
    }
}