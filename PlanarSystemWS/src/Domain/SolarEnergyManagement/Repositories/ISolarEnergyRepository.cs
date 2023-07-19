namespace PlanarSystemWS.src.Domain.SolarEnergyManagement;

public interface ISolarEnergyRepository
{
    Task SaveBudgetForm(RefBudgetForm budgetForm);
    Task<RefBudgetForm> FindBudgetFormById(Guid id);
    Task UpdateBudgetForm(RefBudgetForm origin, RefBudgetForm updated);
}