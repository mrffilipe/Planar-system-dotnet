namespace PlanarSystemWS.src.Domain.Shared;

public interface IEventHandler<TEvent> where TEvent : class
{
    Task HandleEvent(TEvent @event);
}
