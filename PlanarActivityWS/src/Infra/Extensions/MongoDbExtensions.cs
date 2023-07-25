using MongoDB.Driver;

namespace PlanarActivityWS.src.Infra;

public static class MongoDbExtensions
{
    private const string CONNECTION_STRING = "mongodb://localhost:27017";

    public static IServiceCollection AddMongoDb(this IServiceCollection services)
    {
        IMongoClient client = new MongoClient(CONNECTION_STRING);

        services.AddSingleton(client);

        return services;
    }
}