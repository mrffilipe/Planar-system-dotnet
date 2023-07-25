using RabbitMQ.Client;

namespace PlanarUserAccountWS.src.Infra;

public interface IRabbitMQService
{
    IConnection CreateConnection();
}