namespace PlanarSystemWS.src.Infra;

public class CompositeBackgroundService : BackgroundService
{
    private readonly IEnumerable<IHostedService> _hostedServices;

    public CompositeBackgroundService(IEnumerable<IHostedService> hostedServices)
    {
        _hostedServices = hostedServices;
    }

    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var tasks = new List<Task>();

        foreach (var hostedService in _hostedServices)
        {
            tasks.Add(hostedService.StartAsync(stoppingToken));
        }

        return Task.WhenAll(tasks);
    }

    public override async Task StopAsync(CancellationToken stoppingToken)
    {
        var tasks = new List<Task>();

        foreach (var hostedService in _hostedServices)
        {
            tasks.Add(hostedService.StopAsync(stoppingToken));
        }

        await Task.WhenAll(tasks);
    }
}