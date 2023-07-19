using PlanarSystemWS.src.Application.AddressManagement;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public class CustomerRegistrationDTO
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public DocumentRegistrationDTO Document { get; private set; }
    public PhoneRegistrationDTO Phone { get; private set; }
    public AddressRegistrationDTO Address { get; private set; }
}
