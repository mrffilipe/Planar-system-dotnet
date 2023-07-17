using RabbitMQ.Client;

namespace PlanarSystemWS.src.Infra;

public class RabbitMQService
{
    public IConnection CreateConnection()
    {
        var factory = new ConnectionFactory
        {
            HostName = "localhost",
        };

        return factory.CreateConnection();
    }
}