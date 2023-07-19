using AutoMapper;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<CustomerRegistrationDTO, Customer>();
        CreateMap<Customer, DetailedReplyCustomerDTO>();
        CreateMap<Customer, ReplyCustomerDTO>();

        CreateMap<DocumentRegistrationDTO, RefDocument>();
        CreateMap<RefDocument, ReplyDocumentDTO>();

        CreateMap<PhoneRegistrationDTO, RefPhone>();
        CreateMap<RefPhone, ReplyPhoneDTO>();
    }
}