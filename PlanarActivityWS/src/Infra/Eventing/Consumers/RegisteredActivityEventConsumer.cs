using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public class RegisteredActivityEventConsumer<TEvent> : EventConsumer<TEvent> where TEvent : IEvent
{
    private const string QUEUE_NAME = "new-registered-activity";

    public RegisteredActivityEventConsumer(IRabbitMQService rabbitMQService, IServiceScopeFactory scopeFactory)
        : base(rabbitMQService, QUEUE_NAME, scopeFactory)
    {
    }
}