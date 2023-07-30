namespace PlanarAuthenticationWS.src.Domain;

public abstract class BaseEntity : IEntity
{
    public string Id { get; protected set; } = "";
    public string UserAccountId { get; protected set; } = "";
    public DateTime CreatedOn { get; protected set; }
    public DateTime UpdatedOn { get; protected set; }
}