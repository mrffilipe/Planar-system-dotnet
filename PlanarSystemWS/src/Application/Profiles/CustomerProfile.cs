using AutoMapper;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public class CustomerProfile : Profile
{
    public CustomerProfile()
    {
        CreateMap<RegisterCustomerDTO, Customer>()
            .ConstructUsing(s => new Customer(
                s.FirstName,
                s.LastName,
                s.Email,
                new RefDocument(s.Document.Document),
                new RefPhone(s.Phone.IsWhatsapp, s.Phone.Phone),
                new RefAddress(s.Address.Address)
                )
            );

        CreateMap<Customer, CustomerResponseDTO>();
        CreateMap<Customer, MinimumCustomerResponseDTO>();
    }
}