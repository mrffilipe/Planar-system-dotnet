using PlanarSystemWS.src.Domain.Shared;

namespace PlanarSystemWS.src.Domain.UserManagement;

public class RegisteredUserEvent : BaseEvent
{
    public string Queue { get; set; } = "teste";
}