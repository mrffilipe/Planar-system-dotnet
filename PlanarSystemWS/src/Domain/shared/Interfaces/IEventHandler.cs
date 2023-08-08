namespace PlanarSystemWS.src.Domain.Shared;

public interface IEventHandler<TEvent> where TEvent : IEvent
{
    Task HandleEvent(TEvent @event);
}