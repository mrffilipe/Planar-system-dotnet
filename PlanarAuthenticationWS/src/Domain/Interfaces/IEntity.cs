namespace PlanarAuthenticationWS.src.Domain;

public interface IEntity<TKey>
{
    TKey Id { get; }
    TKey UserAccountId { get; }
    DateTime CreatedOn { get; }
    DateTime UpdatedOn { get; }
}