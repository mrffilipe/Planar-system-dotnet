using Microsoft.EntityFrameworkCore;
using PlanarSystemWS.src.Domain.CustomerManagement;
using PlanarSystemWS.src.Domain.Shared;

namespace PlanarSystemWS.src.Domain.AddressManagement;

public class RefAddress : BaseEntity
{
    public Address Address { get; private set; }
    public Customer? Customer { get; private set; }

    public RefAddress()
    {
    }

    public RefAddress(Address address)
    {
        Address = address;
    }

    public void UpdateAddress(Address address)
    {
        //if (address != Address) Address = address;
    }
}