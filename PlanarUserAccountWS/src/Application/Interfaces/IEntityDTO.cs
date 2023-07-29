namespace PlanarUserAccountWS.src.Application;

public interface IEntityDTO
{
    public Guid Id { get; }
    public DateTime CreatedOn { get; }
    public DateTime UpdatedOn { get; }
}