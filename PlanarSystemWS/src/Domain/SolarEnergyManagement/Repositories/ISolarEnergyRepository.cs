namespace PlanarSystemWS.src.Domain.SolarEnergyManagement;

public interface ISolarEnergyRepository
{
    void SaveBudgetForm(RefBudgetForm budgetForm);
    RefBudgetForm FindBudgetFormById(string id);
    void UpdateBudgetForm(RefBudgetForm budgetForm);
}