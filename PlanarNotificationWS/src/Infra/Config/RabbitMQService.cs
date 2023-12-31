﻿using RabbitMQ.Client;

namespace PlanarNotificationWS.src.Infra;

public class RabbitMQService : IRabbitMQService
{
    public IConnection CreateConnection()
    {
        var factory = new ConnectionFactory
        {
            HostName = "localhost"
        };

        // Exceção caso der erro na conexão CreateConnection()

        return factory.CreateConnection();
    }
}