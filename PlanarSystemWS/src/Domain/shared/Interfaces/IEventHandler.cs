namespace PlanarSystemWS.src.Domain.Shared;

public interface IEventHandler<TEvent> where TEvent : BaseEvent
{
    Task HandleEvent(TEvent @event);
}
