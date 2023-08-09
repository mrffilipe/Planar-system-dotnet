using AutoMapper;
using PlanarSalesWS.src.Application;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

public class SolarEnergyAdapter : ISolarEnergyAdapter
{
    private readonly ISolarEnergyService _solarEnergyService;
    private readonly IMapper _mapper;

    public SolarEnergyAdapter(ISolarEnergyService solarEnergyService, IMapper mapper)
    {
        _solarEnergyService = solarEnergyService;
        _mapper = mapper;
    }

    public async Task<DetailedBudgetFormResponseDTO> SaveBudgetForm(RegisterBudgetFormDTO budgetForm)
    {
        try
        {
            var budgetFormMap = _mapper.Map<RefBudgetForm>(budgetForm);

            var result = await _solarEnergyService.SaveBudgetForm(budgetFormMap);

            return _mapper.Map<DetailedBudgetFormResponseDTO>(result);
        }
        catch (Exception ex) { throw; }
    }

    //public async Task<ReplyBudgetFormDTO> FindBudgetFormById(Guid id)
    //{
    //    try
    //    {
    //        var budgetForm = await _solarEnergyService.FindBudgetFormById(id);

    //        return _mapper.Map<ReplyBudgetFormDTO>(budgetForm);
    //    }
    //    catch (Exception ex) { throw; }
    //}

    //public async Task UpdateBudgetForm(BudgetFormRegistrationDTO origin, BudgetFormRegistrationDTO updated)
    //{
    //    try
    //    {
    //        var originMap = _mapper.Map<RefBudgetForm>(origin);
    //        var updatedMap = _mapper.Map<RefBudgetForm>(updated);

    //        await _solarEnergyService.UpdateBudgetForm(originMap, updatedMap);
    //    }
    //    catch (Exception ex) { throw; }
    //}
}