namespace PlanarUserAccountWS.src.Domain;

public abstract class BaseEntity : IEntity<Guid>
{
    public Guid Id { get; protected set; }
    public DateTime CreatedOn { get; protected set; }
    public DateTime UpdatedOn { get; protected set; }
}