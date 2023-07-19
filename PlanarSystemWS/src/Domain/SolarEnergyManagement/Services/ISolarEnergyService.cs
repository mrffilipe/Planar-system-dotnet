namespace PlanarSystemWS.src.Domain.SolarEnergyManagement;

public interface ISolarEnergyService
{
    Task SaveBudgetForm(RefBudgetForm budgetForm);
    Task<RefBudgetForm> FindBudgetFormById(Guid id);
    Task UpdateBudgetForm(RefBudgetForm budgetForm);
}