using PlanarUserAccountWS.src.Domain;
using RabbitMQ.Client;

namespace PlanarUserAccountWS.src.Infra;

public class EventProducer<TEvent> where TEvent : BaseEvent
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
            channel.ExchangeDeclare(
                    exchange: @event.Exchange,
                    type: "fanout",
                    durable: true,
                    autoDelete: false,
                    arguments: null
                );

            channel.QueueDeclare(
                    queue: @event.Queue,
                    durable: true,
                    exclusive: false,
                    autoDelete: false,
                    arguments : null
                );

            channel.QueueBind(
                    queue: @event.Queue,
                    exchange: @event.Exchange,
                    routingKey: @event.RoutingKey,
                    arguments: null
                );

            var props = channel.CreateBasicProperties();
            props.DeliveryMode = 2;

            channel.BasicPublish(
                    exchange: @event.Exchange,
                    routingKey: @event.RoutingKey,
                    basicProperties: props,
                    body: @event.GetSerializationBytes()
                );

            channel.Close();
        }
    }
}