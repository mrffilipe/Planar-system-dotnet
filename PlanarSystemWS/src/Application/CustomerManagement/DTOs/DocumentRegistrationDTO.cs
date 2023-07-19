using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public class DocumentRegistrationDTO
{
    public DocumentType Type { get; set; }
    public string Reference { get; set; }
}
