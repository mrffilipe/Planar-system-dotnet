using PlanarSystemWS.src.Domain.AddressManagement;

namespace PlanarSystemWS.src.Application.AddressManagement;

public class AddressService : IAddressService
{
    private readonly IAddressRepository _addressRepository;

    public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public Task Save(RefAddress address)
    {
        throw new NotImplementedException();
    }

    public Task<RefAddress> FindById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Update(RefAddress address)
    {
        throw new NotImplementedException();
    }
}