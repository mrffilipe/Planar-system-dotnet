using PlanarSystemWS.src.Domain.SalesManagement;
using PlanarSystemWS.src.Domain.Shared;

namespace PlanarSystemWS.src.Domain.UserManagement;

public class User : BaseEntity
{
    public string UserAccountId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Seller? Seller { get; private set; }

    private User()
    {
    }

    public User(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public User(
        string userAccountId,
        string firstName,
        string lastName
        ) : this(firstName, lastName)
    {
        UserAccountId = userAccountId;
        Seller = new Seller(this, 5);
    }
}