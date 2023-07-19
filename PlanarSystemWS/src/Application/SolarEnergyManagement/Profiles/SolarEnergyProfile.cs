using AutoMapper;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Application.SolarEnergyManagement;

public class SolarEnergyProfile : Profile
{
    public SolarEnergyProfile()
    {
        CreateMap<BudgetFormRegistrationDTO, RefBudgetForm>();
        CreateMap<RefBudgetForm, ReplyBudgetFormDTO>();

        CreateMap<ConsumerUnitRegistrationDTO, ConsumerUnit>();
        CreateMap<ConsumerUnit, ReplyConsumerUnitDTO>();
    }
}
