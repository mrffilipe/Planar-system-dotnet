namespace PlanarSystemWS.src.Domain.Shared;

public interface IEvent
{
    string Queue { get; }
    string Exchange { get; }
    string RoutingKey { get; }
}
