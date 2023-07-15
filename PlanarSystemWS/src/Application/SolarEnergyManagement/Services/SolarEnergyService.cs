using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public class SolarEnergyService : ISolarEnergyService
{
    private readonly ISolarEnergyRepository _solarEnergyRepository;

    public SolarEnergyService(ISolarEnergyRepository solarEnergyRepository)
    {
        _solarEnergyRepository = solarEnergyRepository;
    }

    public void SaveBudgetForm(RefBudgetForm budgetForm)
    {
        throw new NotImplementedException();
    }

    public RefBudgetForm FindBudgetFormById(string id)
    {
        throw new NotImplementedException();
    }

    public void UpdateBudgetForm(RefBudgetForm budgetForm)
    {
        throw new NotImplementedException();
    }
}