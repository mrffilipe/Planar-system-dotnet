using AutoMapper;
using PlanarSystemWS.src.Domain.AddressManagement;

namespace PlanarSystemWS.src.Application.AddressManagement;

public class AddressProfile : Profile
{
    public AddressProfile()
    {
        CreateMap<AddressRegistrationDTO, RefAddress>();
        CreateMap<RefAddress, ReplyAddressDTO>();
    }
}
