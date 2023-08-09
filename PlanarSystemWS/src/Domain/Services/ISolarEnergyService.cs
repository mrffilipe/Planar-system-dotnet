namespace PlanarSalesWS.src.Domain;

public interface ISolarEnergyService
{
    Task<RefBudgetForm> SaveBudgetForm(RefBudgetForm budgetForm);
    Task<RefBudgetForm> FindBudgetFormById(Guid id);
    Task<RefBudgetForm> UpdateBudgetForm(RefBudgetForm origin, RefBudgetForm updated);
}