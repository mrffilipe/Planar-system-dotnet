using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public class RegisteredUserEventConsumer<TEvent> : EventConsumer<TEvent> where TEvent : IEvent
{
    private const string QUEUE_NAME = "new-registered-user";

    public RegisteredUserEventConsumer(IRabbitMQService rabbitMQService, IServiceScopeFactory scopeFactory)
        : base(rabbitMQService, QUEUE_NAME, scopeFactory)
    {
    }
}