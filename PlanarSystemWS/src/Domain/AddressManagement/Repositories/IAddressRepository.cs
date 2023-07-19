namespace PlanarSystemWS.src.Domain.AddressManagement;

public interface IAddressRepository
{
    Task Save(RefAddress address);
    Task<RefAddress> FindById(Guid id);
    Task Update(RefAddress address);
}
