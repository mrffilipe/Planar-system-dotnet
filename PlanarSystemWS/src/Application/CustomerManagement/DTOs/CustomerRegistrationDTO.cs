using PlanarSystemWS.src.Application.AddressManagement;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public class CustomerRegistrationDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DocumentRegistrationDTO Document { get; set; }
    public PhoneRegistrationDTO Phone { get; set; }
    public AddressRegistrationDTO Address { get; set; }
}
