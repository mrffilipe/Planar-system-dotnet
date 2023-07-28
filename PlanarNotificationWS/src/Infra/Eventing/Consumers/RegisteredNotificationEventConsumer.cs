using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Infra;

public class RegisteredNotificationEventConsumer<TEvent> : EventConsumer<TEvent> where TEvent : IEvent
{
    private const string QUEUE_NAME = "new-registered-notification";

    public RegisteredNotificationEventConsumer(IRabbitMQService rabbitMQService, IServiceScopeFactory scopeFactory)
        : base(rabbitMQService, QUEUE_NAME, scopeFactory)
    {
    }
}