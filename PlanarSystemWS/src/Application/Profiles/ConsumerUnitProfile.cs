using AutoMapper;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public class ConsumerUnitProfile : Profile
{
    public ConsumerUnitProfile()
    {
        CreateMap<RegisterConsumerUnitDTO, ConsumerUnit>();

        CreateMap<ConsumerUnit, MinimumConsumerUnitResponseDTO>();
    }
}