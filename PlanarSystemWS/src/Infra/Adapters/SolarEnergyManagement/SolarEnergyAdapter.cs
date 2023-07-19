using AutoMapper;
using PlanarSystemWS.src.Application.SolarEnergyManagement;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Infra.Adapters.SolarEnergyManagement;

public class SolarEnergyAdapter : ISolarEnergyAdapter
{
    private readonly ISolarEnergyService _solarEnergyService;
    private readonly IMapper _mapper;

    public SolarEnergyAdapter(ISolarEnergyService solarEnergyService, IMapper mapper)
    {
        _solarEnergyService = solarEnergyService;
        _mapper = mapper;
    }

    public async Task SaveBudgetForm(BudgetFormRegistrationDTO budgetForm)
    {
        try
        {
            var budgetFormMap = _mapper.Map<RefBudgetForm>(budgetForm);

            await _solarEnergyService.SaveBudgetForm(budgetFormMap);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<ReplyBudgetFormDTO> FindBudgetFormById(Guid id)
    {
        try
        {
            var budgetForm = await _solarEnergyService.FindBudgetFormById(id);

            return _mapper.Map<ReplyBudgetFormDTO>(budgetForm);
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateBudgetForm(BudgetFormRegistrationDTO origin, BudgetFormRegistrationDTO updated)
    {
        try
        {
            var originMap = _mapper.Map<RefBudgetForm>(origin);
            var updatedMap = _mapper.Map<RefBudgetForm>(updated);

            await _solarEnergyService.UpdateBudgetForm(originMap, updatedMap);
        }
        catch (Exception ex) { throw; }
    }
}
