namespace PlanarSystemWS.src.Application.Shared;

public interface IEntityDTO
{
    public Guid Id { get; }

    public DateTime CreatedOn { get; }

    public DateTime UpdatedOn { get; }
}