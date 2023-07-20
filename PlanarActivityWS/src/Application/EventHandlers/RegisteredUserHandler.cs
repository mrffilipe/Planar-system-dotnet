using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

public class RegisteredUserHandler : IEventHandler<RegisteredUserEvent>
{
    public Task HandleEvent(RegisteredUserEvent @event)
    {
        throw new NotImplementedException();
    }
}