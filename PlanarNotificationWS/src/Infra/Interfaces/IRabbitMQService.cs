using RabbitMQ.Client;

namespace PlanarNotificationWS.src.Infra;

public interface IRabbitMQService
{
    IConnection CreateConnection();
}