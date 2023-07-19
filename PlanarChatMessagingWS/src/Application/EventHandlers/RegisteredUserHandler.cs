using PlanarChatMessagingWS.src.Domain;

namespace PlanarChatMessagingWS.src.Application;

public class RegisteredUserHandler : IEventHandler<RegisteredUserEvent>
{
    public Task HandleEvent(RegisteredUserEvent @event)
    {
        throw new NotImplementedException();
    }
}