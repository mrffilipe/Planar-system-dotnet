using System.Collections.ObjectModel;

namespace PlanarSalesWS.src.Domain;

public class MinimumUserCreatedEvent : IEvent
{
    public string UserAccountId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public ICollection<EventConfiguration> Configurations => new Collection<EventConfiguration>()
    {
        new EventConfiguration("user-events_sales_service", "user-events", "user.minimum-user-created")
    };

    public MinimumUserCreatedEvent(
       string userAccountId,
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