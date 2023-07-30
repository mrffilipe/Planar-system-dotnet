using RabbitMQ.Client;

namespace PlanarAuthenticationWS.src.Infra;

public interface IRabbitMQService
{
    IConnection CreateConnection();
}