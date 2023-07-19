using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public class ReplyPhoneDTO
{
    public bool IsWhatsapp { get; private set; }
    public Phone Phone { get; private set; }
}
