using PlanarSystemWS.src.Domain.shared;

namespace PlanarSystemWS.src.Domain.AddressManagement;

public class RefAddress : BaseEntity
{
    public Address Address { get; private set; }

    public RefAddress(Address address)
    {
        Address = address;
    }

    public void UpdateAddress(Address address)
    {
        if (address != Address) Address = address;
    }
}