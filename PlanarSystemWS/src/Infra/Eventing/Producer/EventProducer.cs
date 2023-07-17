using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace PlanarSystemWS.src.Infra;

public class EventProducer<TEvent> where TEvent : class
{
    private readonly IConnection _connection;

    public EventProducer(RabbitMQService rabbitMQService)
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
                    exchange: "",
                    routingKey: "teste",
                    basicProperties: null,
                    body: body
                );
        }
    }
}
