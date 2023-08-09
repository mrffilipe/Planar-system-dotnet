using AutoMapper;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public class SellerProfile : Profile
{
    public SellerProfile()
    {
        CreateMap<RegisteredUserEvent, Seller>()
            .ConstructUsing(s => new Seller(
                s.UserAccountId,
                s.FirstName,
                s.LastName
                )
            );

        CreateMap<Seller, SellerResponseDTO>();
        CreateMap<Seller, MinimumSellerResponseDTO>();
    }
}