using RabbitMQ.Client;

namespace PlanarActivityWS.src.Infra;

public interface IRabbitMQService
{
    IConnection CreateConnection();
}