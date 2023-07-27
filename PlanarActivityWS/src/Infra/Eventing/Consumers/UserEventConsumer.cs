using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public class UserEventConsumer<TEvent> : EventConsumer<TEvent> where TEvent : BaseEvent
{
    private const string QUEUE_NAME = "new-registered-user";

    public UserEventConsumer(IRabbitMQService rabbitMQService, IServiceScopeFactory scopeFactory)
        : base(rabbitMQService, QUEUE_NAME, scopeFactory)
    {
    }
}