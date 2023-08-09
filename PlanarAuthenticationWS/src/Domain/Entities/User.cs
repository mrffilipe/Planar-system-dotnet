namespace PlanarAuthenticationWS.src.Domain;

public class User : BaseEntity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }

    public User(
        Guid userAccountId,
        string firstName,
        string lastName,
        string email
        )
    {
        UserAccountId = userAccountId;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }
}