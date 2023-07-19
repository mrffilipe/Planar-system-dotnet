using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public class SolarEnergyService : ISolarEnergyService
{
    private readonly ISolarEnergyRepository _solarEnergyRepository;

    public SolarEnergyService(ISolarEnergyRepository solarEnergyRepository)
    {
        _solarEnergyRepository = solarEnergyRepository;
    }

    public Task SaveBudgetForm(RefBudgetForm budgetForm)
    {
        throw new NotImplementedException();
    }

    public Task<RefBudgetForm> FindBudgetFormById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateBudgetForm(RefBudgetForm budgetForm)
    {
        throw new NotImplementedException();
    }
}