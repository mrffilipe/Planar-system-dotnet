using PlanarSystemWS.src.Domain.Shared;

namespace PlanarSystemWS.src.Domain.UserManagement;

public class RegisteredUserEvent : BaseEvent
{
    public override string Queue { get; protected set; } = "teste";
    public override string Exchange { get; protected set; }
    public override string RoutingKey { get; protected set; }
}