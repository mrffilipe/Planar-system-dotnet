using AutoMapper;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<RegisterAddressDTO, RefAddress>()
            .ConstructUsing(s => new RefAddress(
                s.Address
                )
            );

        CreateMap<RefAddress, MinimumAddressResponseDTO>();
    }
}