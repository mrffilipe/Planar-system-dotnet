namespace PlanarSystemWS.src.Domain.shared;

public interface IEntity<TKey>
{
    TKey Id { get; }
    DateTime CreatedOn { get; }
    DateTime UpdatedOn { get; }
}
