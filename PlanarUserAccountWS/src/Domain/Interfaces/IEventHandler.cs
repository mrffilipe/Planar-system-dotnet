namespace PlanarUserAccountWS.src.Domain;

public interface IEventHandler<TEvent> where TEvent : BaseEvent
{
    Task HandleEvent(TEvent @event);
}