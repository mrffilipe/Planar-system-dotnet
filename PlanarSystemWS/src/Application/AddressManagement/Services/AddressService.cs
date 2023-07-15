using PlanarSystemWS.src.Domain.AddressManagement;

namespace PlanarSystemWS.src.Application.AddressManagement;

public class AddressService : IAddressService
{
    private readonly IAddressRepository _addressRepository;

    public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public void Save(RefAddress address)
    {
        throw new NotImplementedException();
    }

    public RefAddress FindById(string id)
    {
        throw new NotImplementedException();
    }

    public void Update(RefAddress address)
    {
        throw new NotImplementedException();
    }
}