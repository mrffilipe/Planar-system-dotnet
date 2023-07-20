namespace PlanarActivityWS.src.Domain;

public interface IEvent
{
    string Queue { get; }
    string Exchange { get; }
    string RoutingKey { get; }
}