using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public class UpdatedUserEventConsumer<TEvent> : EventConsumer<TEvent> where TEvent : IEvent
{
    private const string QUEUE_NAME = "updated-user";

    public UpdatedUserEventConsumer(IRabbitMQService rabbitMQService, IServiceScopeFactory scopeFactory)
        : base(rabbitMQService, QUEUE_NAME, scopeFactory)
    {
    }
}