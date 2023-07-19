using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Infra.Repositories.SolarEnergyManagement;

public class SolarEnergyRepository : ISolarEnergyRepository
{
    // ...

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
