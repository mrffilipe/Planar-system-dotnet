using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public class PhoneRegistrationDTO
{
    public bool IsWhatsapp { get; private set; }
    public Phone Phone { get; private set; }
}
