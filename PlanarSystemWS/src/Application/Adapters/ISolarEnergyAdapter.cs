namespace PlanarSalesWS.src.Application;

public interface ISolarEnergyAdapter
{
    Task<DetailedBudgetFormResponseDTO> SaveBudgetForm(RegisterBudgetFormDTO budgetForm);
    //Task<ReplyBudgetFormDTO> FindBudgetFormById(Guid id);
    //Task UpdateBudgetForm(BudgetFormRegistrationDTO origin, BudgetFormRegistrationDTO updated);
}