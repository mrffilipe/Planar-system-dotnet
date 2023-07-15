namespace PlanarSystemWS.src.Domain.SolarEnergyManagement;

public interface ISolarEnergyService
{
    void SaveBudgetForm(RefBudgetForm budgetForm);
    RefBudgetForm FindBudgetFormById(string id);
    void UpdateBudgetForm(RefBudgetForm budgetForm);
}