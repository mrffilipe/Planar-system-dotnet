using AutoMapper;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public class PhoneProfile : Profile
{
    public PhoneProfile()
    {
        CreateMap<RegisterPhoneDTO, RefPhone>()
            .ConstructUsing(s => new RefPhone(
                s.IsWhatsapp,
                s.Phone
                )
            );
    }
}