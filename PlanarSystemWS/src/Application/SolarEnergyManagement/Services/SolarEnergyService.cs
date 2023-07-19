using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public class SolarEnergyService : ISolarEnergyService
{
    private readonly ISolarEnergyRepository _solarEnergyRepository;

    public SolarEnergyService(ISolarEnergyRepository solarEnergyRepository)
    {
        _solarEnergyRepository = solarEnergyRepository;
    }

    public async Task SaveBudgetForm(RefBudgetForm budgetForm)
    {
        try
        {
            await _solarEnergyRepository.SaveBudgetForm(budgetForm);
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

    public async Task UpdateBudgetForm(RefBudgetForm origin, RefBudgetForm updated)
    {
        try
        {
            if (origin != null && updated != null)
            {
                await _solarEnergyRepository.UpdateBudgetForm(origin, updated);
            }
        }
        catch (Exception ex) { throw; }
    }
}