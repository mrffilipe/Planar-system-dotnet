namespace PlanarNotificationWS.src.Application;

public interface IEntityDTO
{
    public string Id { get; }
    public DateTime CreatedOn { get; }
    public DateTime UpdatedOn { get; }
}