using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Application;

public class RegisteredUserHandler : IEventHandler<RegisteredUserEvent>
{
    public Task HandleEvent(RegisteredUserEvent @event)
    {
        throw new NotImplementedException();
    }
}