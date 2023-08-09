using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public record RegisterPhoneDTO(
    bool IsWhatsapp,
    Phone Phone
    );