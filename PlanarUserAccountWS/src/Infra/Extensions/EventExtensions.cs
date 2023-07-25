namespace PlanarUserAccountWS.src.Infra;

public static class EventExtensions
{
    public static IServiceCollection AddEvents(this IServiceCollection services)
    {
        services.AddScoped(typeof(EventProducer<>));

        return services;
    }
}
