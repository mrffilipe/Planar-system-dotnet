using Newtonsoft.Json;
using PlanarSystemWS.src.Domain.Shared;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace PlanarSystemWS.src.Infra
{
    public class EventConsumer<TEvent> : BackgroundService where TEvent : class
    {
        private readonly IConnection _connection;
        private readonly IEventHandler<TEvent> _eventHandler;

        public EventConsumer(IRabbitMQService rabbitMQService, IEventHandler<TEvent> eventHandler)
        {
            _connection = rabbitMQService.CreateConnection();
            _eventHandler = eventHandler;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var channel = _connection.CreateModel();
            channel.QueueDeclare(
                queue: "teste",
                durable: true,
                exclusive: false,
                autoDelete: false,
                arguments: null
            );

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += async (model, eventArgs) =>
            {
                var body = eventArgs.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                var eventData = JsonConvert.DeserializeObject<TEvent>(message);

                // Verificar exceção eventData == null

                // Executar handle
                await _eventHandler.HandleEvent(eventData);

                // Confirma o evento recebido com sucesso
                channel.BasicAck(eventArgs.DeliveryTag, multiple: false);
            };

            channel.BasicConsume(
                queue: "teste",
                autoAck: false,
                consumer: consumer
            );

            await Task.CompletedTask;
        }
    }
}