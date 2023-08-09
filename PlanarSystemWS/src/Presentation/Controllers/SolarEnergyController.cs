using Microsoft.AspNetCore.Mvc;
using PlanarSalesWS.src.Application;

namespace PlanarSalesWS.src.Presentation;

public class SolarEnergyController : BaseController
{
    private readonly ISolarEnergyAdapter _solarEnergyAdapter;

    public SolarEnergyController(ISolarEnergyAdapter solarEnergyAdapter)
    {
        _solarEnergyAdapter = solarEnergyAdapter;
    }

    [HttpPost]
    [Route("save-budget-form")]
    public async Task<ActionResult<DetailedBudgetFormResponseDTO>> SaveBudgetForm([FromBody] RegisterBudgetFormDTO budgetForm)
    {
        try
        {
            var result = await _solarEnergyAdapter.SaveBudgetForm(budgetForm);

            return Ok(result);
        }
        catch (Exception ex) { throw; }
    }
}