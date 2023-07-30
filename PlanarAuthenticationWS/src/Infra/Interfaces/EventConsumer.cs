using Newtonsoft.Json;
using PlanarAuthenticationWS.src.Domain;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace PlanarAuthenticationWS.src.Infra;

public abstract class EventConsumer<TEvent> : BackgroundService where TEvent : IEvent
{
    private readonly IConnection _connection;
    private readonly IModel _channel;
    private readonly string _queueName;
    private readonly IServiceScopeFactory _scopeFactory;

    protected EventConsumer(IRabbitMQService rabbitMQService, string queueName, IServiceScopeFactory scopeFactory)
    {
        _connection = rabbitMQService.CreateConnection();
        _channel = _connection.CreateModel();
        _queueName = queueName;
        _scopeFactory = scopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            var consumer = new EventingBasicConsumer(_channel);

            consumer.Received += async (sender, eventArgs) =>
            {
                try
                {
                    var body = eventArgs.Body.ToArray();
                    var strJson = Encoding.UTF8.GetString(body);

                    var @event = DeserializeEvent(strJson);
                    if (@event == null)
                    {
                        return;
                    }

                    using (var scope = _scopeFactory.CreateScope())
                    {
                        var handler = scope.ServiceProvider.GetRequiredService<IEventHandler<TEvent>>();

                        await handler.HandleEvent(@event);
                    }

                    _channel.BasicAck(eventArgs.DeliveryTag, multiple: false);
                }
                catch (Exception ex) { throw; }
            };

            _channel.QueueDeclare(
                    queue: _queueName,
                    durable: true,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null
                );

            _channel.BasicConsume(
                       queue: _queueName,
                       autoAck: false,
                       consumer: consumer
                   );

            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(100, stoppingToken);
            }
        }
        catch (Exception ex) { throw; }
    }

    public override void Dispose()
    {
        _channel.Dispose();
        _connection.Dispose();
        base.Dispose();
    }

    private static TEvent DeserializeEvent(string strJson)
    {
        try
        {
            if (strJson == null)
            {
                throw new Exception();
            }

            var @event = JsonConvert.DeserializeObject<TEvent>(strJson);
            if (@event == null)
            {
                throw new Exception();
            }

            return @event;
        }
        catch (Exception ex) { throw; }
    }
}