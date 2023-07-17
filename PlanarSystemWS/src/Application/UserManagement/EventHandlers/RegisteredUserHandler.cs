using PlanarSystemWS.src.Domain.Shared;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Application.UserManagement;

public class RegisteredUserHandler : IEventHandler<RegisteredUserEvent>
{
    public Task HandleEvent(RegisteredUserEvent @event)
    {
        throw new NotImplementedException();
    }
}
