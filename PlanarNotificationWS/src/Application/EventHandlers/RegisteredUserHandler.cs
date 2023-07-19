using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class RegisteredUserHandler : IEventHandler<RegisteredUserEvent>
{
    public Task HandleEvent(RegisteredUserEvent @event)
    {
        throw new NotImplementedException();
    }
}