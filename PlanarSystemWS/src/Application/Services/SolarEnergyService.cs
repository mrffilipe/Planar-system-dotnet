using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public class SolarEnergyService : ISolarEnergyService
{
    private readonly ISolarEnergyRepository _solarEnergyRepository;

    public SolarEnergyService(ISolarEnergyRepository solarEnergyRepository)
    {
        _solarEnergyRepository = solarEnergyRepository;
    }

    public async Task<RefBudgetForm> SaveBudgetForm(RefBudgetForm budgetForm)
    {
        try
        {
            // obter o vendedor
            budgetForm.SetSeller(new Guid("08db98a7-2ea2-4c00-891d-f0e4f4af562a"));

            var result = await _solarEnergyRepository.SaveBudgetForm(budgetForm);

            return result;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<RefBudgetForm> FindBudgetFormById(Guid id)
    {
        try
        {
            var budgetForm = await _solarEnergyRepository.FindBudgetFormById(id);

            return budgetForm;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<RefBudgetForm> UpdateBudgetForm(RefBudgetForm origin, RefBudgetForm updated)
    {
        try
        {
            if (origin != null && updated != null)
            {
                var result = await _solarEnergyRepository.UpdateBudgetForm(origin, updated);

                return result;
            }

            throw new Exception();
        }
        catch (Exception ex) { throw; }
    }
}