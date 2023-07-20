namespace PlanarUserAccountWS.src.Domain;

public interface IEntity<TKey>
{
    TKey Id { get; }
    DateTime CreatedOn { get; }
    DateTime UpdatedOn { get; }
}