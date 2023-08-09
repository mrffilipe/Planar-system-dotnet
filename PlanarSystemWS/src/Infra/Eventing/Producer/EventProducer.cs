using Newtonsoft.Json;
using PlanarSalesWS.src.Domain;
using RabbitMQ.Client;
using System.Text;

namespace PlanarSalesWS.src.Infra;

public class EventProducer<TEvent> where TEvent : IEvent
{
    private readonly IConnection _connection;

    public EventProducer(IRabbitMQService rabbitMQService)
    {
        _connection = rabbitMQService.CreateConnection();
    }

    public void PublishEvent(TEvent @event)
    {
        using (var channel = _connection.CreateModel())
        {
            var message = JsonConvert.SerializeObject(@event);
            var body = Encoding.UTF8.GetBytes(message);

            channel.BasicPublish(
                    exchange: @event.Exchange,
                    routingKey: @event.RoutingKey,
                    basicProperties: null,
                    body: body
                );
        }
    }
}