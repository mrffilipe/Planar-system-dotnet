using Microsoft.AspNetCore.Identity;

namespace PlanarAuthenticationWS.src.Domain;

public abstract class BaseIdentityUser : IdentityUser, IEntity
{
    public abstract string UserAccountId { get; set; }
    public DateTime CreatedOn { get; protected set; }
    public DateTime UpdatedOn { get; protected set; }
}