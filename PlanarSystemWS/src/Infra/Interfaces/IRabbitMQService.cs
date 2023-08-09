using RabbitMQ.Client;

namespace PlanarSalesWS.src.Infra;

public interface IRabbitMQService
{
    IConnection CreateConnection();
}