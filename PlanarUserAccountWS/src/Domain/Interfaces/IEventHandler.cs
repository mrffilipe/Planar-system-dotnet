namespace PlanarUserAccountWS.src.Domain;

public interface IEventHandler<TEvent> where TEvent : IEvent
{
    Task HandleEvent(TEvent @event);
}