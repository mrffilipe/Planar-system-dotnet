namespace PlanarSystemWS.src.Domain.shared;

public abstract class BaseEntity : IEntity<string>
{
    public string Id { get; private set; }

    public DateTime CreatedOn { get; private set; }

    public DateTime UpdatedOn { get; private set; }
}
