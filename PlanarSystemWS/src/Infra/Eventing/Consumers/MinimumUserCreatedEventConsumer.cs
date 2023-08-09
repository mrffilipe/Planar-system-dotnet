using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

public class MinimumUserCreatedEventConsumer<TEvent> : EventConsumer<TEvent> where TEvent : IEvent
{
    private const string QUEUE_NAME = "user-events_sales_service";

    public MinimumUserCreatedEventConsumer(IRabbitMQService rabbitMQService, IServiceScopeFactory scopeFactory)
        : base(rabbitMQService, QUEUE_NAME, scopeFactory)
    {
    }
}