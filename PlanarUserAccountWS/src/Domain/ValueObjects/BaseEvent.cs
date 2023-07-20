namespace PlanarUserAccountWS.src.Domain;

public abstract class BaseEvent : IEvent
{
    public string Queue { get; protected set; }
    public string Exchange { get; protected set; }
    public string RoutingKey { get; protected set; }
}