using RabbitMQ.Client;

namespace PlanarSystemWS.src.Infra;

public interface IRabbitMQService
{
    IConnection CreateConnection();
}
