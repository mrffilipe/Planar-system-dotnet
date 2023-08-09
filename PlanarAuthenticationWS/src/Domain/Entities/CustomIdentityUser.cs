using Microsoft.AspNetCore.Identity;

namespace PlanarAuthenticationWS.src.Domain;

public class CustomIdentityUser : IdentityUser<Guid>
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Guid UserAccountId { get; private set; }
    public DateTime CreatedOn { get; private set; }
    public DateTime UpdatedOn { get; private set; }

    public CustomIdentityUser(
            Guid userAccountId,
            string firstName,
            string lastName,
            string email
            )
    {
        UserAccountId = userAccountId;
        FirstName = firstName;
        LastName = lastName;
        UserName = email;
        Email = email;
    }
}