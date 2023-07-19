using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public class PhoneRegistrationDTO
{
    public bool IsWhatsapp { get; set; }
    public Phone Phone { get; set; }
}
