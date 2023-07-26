using Consul;
using Newtonsoft.Json;
using PlanarActivityWS.src.Domain;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace PlanarActivityWS.src.Infra;

public class EventConsumer : BackgroundService
{
    private readonly IConnection _connection;
    private readonly IServiceScopeFactory _scopeFactory;

    public EventConsumer(IRabbitMQService rabbitMQService, IServiceScopeFactory scopeFactory)
    {
        _connection = rabbitMQService.CreateConnection();
        _scopeFactory = scopeFactory;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        try
        {
            using (var channel = _connection.CreateModel())
            {
                var consumer = new EventingBasicConsumer(channel);

                consumer.Received += async (ch, eventArgs) =>
                {
                    try
                    {
                        var body = eventArgs.Body.ToArray();
                        var strJson = Encoding.UTF8.GetString(body);

                        //var @event = JsonConvert.DeserializeObject<BaseEvent>(strJson);
                        var @event = JsonConvert.DeserializeObject<RegisteredUserEvent>(strJson);

                        if (@event == null) return;

                        using (var scope = _scopeFactory.CreateScope())
                        {
                            var eventType = @event.GetType();

                            var eventHandlerType = typeof(IEventHandler<>).MakeGenericType(eventType);

                            dynamic eventHandler = scope.ServiceProvider.GetRequiredService(eventHandlerType);

                            await eventHandler.HandleEvent((dynamic)@event);
                        }

                        channel.BasicAck(eventArgs.DeliveryTag, multiple: false);
                    }
                    catch (Exception ex) { throw; }
                };


                channel.BasicConsume(
                       //queue: @event.Queue,
                       queue: "new-registered-user",
                       autoAck: false,
                       consumer: consumer
                   );

                while(!stoppingToken.IsCancellationRequested)
                {
                    await Task.Delay(100);
                }
            }
        }
        catch (Exception ex) { throw; }
    }

    public override void Dispose()
    {
        _connection.Close();
        base.Dispose();
    }
}