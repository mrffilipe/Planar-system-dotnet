using AutoMapper;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public class BudgetFormProfile : Profile
{
    public BudgetFormProfile()
    {
        CreateMap<RegisterBudgetFormDTO, RefBudgetForm>();

        CreateMap<RefBudgetForm, DetailedBudgetFormResponseDTO>();
    }
}