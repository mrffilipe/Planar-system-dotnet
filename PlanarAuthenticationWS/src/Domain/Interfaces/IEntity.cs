namespace PlanarAuthenticationWS.src.Domain;

public interface IEntity
{
    DateTime CreatedOn { get; }
    DateTime UpdatedOn { get; }
}