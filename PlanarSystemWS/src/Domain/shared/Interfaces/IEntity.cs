namespace PlanarSystemWS.src.Domain.Shared;

public interface IEntity<TKey>
{
    TKey Id { get; }
    DateTime CreatedOn { get; }
    DateTime UpdatedOn { get; }
}
