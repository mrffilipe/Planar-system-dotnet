using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public class UpdatedActivityEventConsumer<TEvent> : EventConsumer<TEvent> where TEvent : IEvent
{
    private const string QUEUE_NAME = "updated-activity";

    public UpdatedActivityEventConsumer(IRabbitMQService rabbitMQService, IServiceScopeFactory scopeFactory)
        : base(rabbitMQService, QUEUE_NAME, scopeFactory)
    {
    }
}