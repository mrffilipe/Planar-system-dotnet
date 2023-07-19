using PlanarSystemWS.src.Domain.AddressManagement;

namespace PlanarSystemWS.src.Infra.Repositories.AddressManagement;

public class AddressRepository : IAddressRepository
{
    // ...

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
