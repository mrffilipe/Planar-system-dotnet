using Newtonsoft.Json;
using PlanarUserAccountWS.src.Domain;
using RabbitMQ.Client;
using System.Text;

namespace PlanarUserAccountWS.src.Infra;

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
            foreach (var config in @event.Configurations)
            {
                channel.ExchangeDeclare(
                    exchange: config.Exchange,
                    type: "topic",
                    durable: true,
                    autoDelete: false,
                    arguments: null
                );

                channel.QueueDeclare(
                        queue: config.Queue,
                        durable: true,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null
                    );

                channel.QueueBind(
                        queue: config.Queue,
                        exchange: config.Exchange,
                        routingKey: config.RoutingKey,
                        arguments: null
                    );

                var props = channel.CreateBasicProperties();
                props.DeliveryMode = 2;

                channel.BasicPublish(
                        exchange: config.Exchange,
                        routingKey: config.RoutingKey,
                        basicProperties: props,
                        body: GetSerializationBytes(@event)
                    );
            }

            channel.Close();
        }
    }

    private static Byte[] GetSerializationBytes(TEvent @event)
    {
        var settings = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        var serialize = JsonConvert.SerializeObject(@event, settings);
        var bytes = Encoding.UTF8.GetBytes(serialize);

        return bytes;
    }
}