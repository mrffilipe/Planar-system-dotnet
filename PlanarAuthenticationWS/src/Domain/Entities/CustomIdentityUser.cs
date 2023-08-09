using Microsoft.AspNetCore.Identity;
using System;

namespace PlanarAuthenticationWS.src.Domain;

public class CustomIdentityUser : IdentityUser<Guid>
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Guid UserAccountId { get; protected set; }
    public DateTime CreatedOn { get; protected set; }
    public DateTime UpdatedOn { get; protected set; }

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