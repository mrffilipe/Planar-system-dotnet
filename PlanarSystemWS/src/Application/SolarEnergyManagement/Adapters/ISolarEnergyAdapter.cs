namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public interface ISolarEnergyAdapter
{
    Task SaveBudgetForm(BudgetFormRegistrationDTO budgetForm);
    Task<ReplyBudgetFormDTO> FindBudgetFormById(Guid id);
    Task UpdateBudgetForm(BudgetFormRegistrationDTO budgetForm);
}
