using AutoMapper;
using PlanarSystemWS.src.Application.AddressManagement;
using PlanarSystemWS.src.Domain.AddressManagement;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<CustomerRegistrationDTO, Customer>();
        CreateMap<Customer, ReplyCustomerDTO>();

        CreateMap<AddressRegistrationDTO, RefAddress>();
        CreateMap<RefAddress, ReplyAddressDTO>();

        CreateMap<DocumentRegistrationDTO, RefDocument>();
        CreateMap<RefDocument, ReplyDocumentDTO>();
    }
}
