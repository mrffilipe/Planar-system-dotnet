using Microsoft.AspNetCore.Mvc;
using PlanarSystemWS.src.Application.SolarEnergyManagement;
using PlanarSystemWS.src.Presentation.Shared.Controllers;

namespace PlanarSystemWS.src.Presentation.CustomerManagement.Controllers;

public class SolarEnergyController : BaseController
{
    private readonly ISolarEnergyAdapter _solarEnergyAdapter;

    public SolarEnergyController(ISolarEnergyAdapter solarEnergyAdapter)
    {
        _solarEnergyAdapter = solarEnergyAdapter;
    }

    [HttpPost]
    public async Task SaveBudgetForm([FromBody] BudgetFormRegistrationDTO budgetForm)
    {
        await _solarEnergyAdapter.SaveBudgetForm(budgetForm);
    }
}