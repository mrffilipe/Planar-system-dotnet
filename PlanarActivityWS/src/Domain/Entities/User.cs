namespace PlanarActivityWS.src.Domain;

public class User : BaseEntity
{
    public string UserAccountId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public IList<Activity> Activities { get; private set; }

    public User(
       string userId,
       string firstName,
       string lastName
       )
    {
        UserAccountId = userId;
        FirstName = firstName;
        LastName = lastName;
        Activities = new List<Activity>();
    }

    public User(
        string userId,
        string firstName,
        string lastName,
        IList<Activity> activities
        ) : base()
    {
        UserAccountId = userId;
        FirstName = firstName;
        LastName = lastName;
        Activities = activities;
    }
}