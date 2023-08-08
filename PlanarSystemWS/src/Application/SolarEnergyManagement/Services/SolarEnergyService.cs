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
            // obter o vendedor
            budgetForm.SetSeller(new Guid("08db97e1-513f-48ec-8976-65e2eca0a4c4"));

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