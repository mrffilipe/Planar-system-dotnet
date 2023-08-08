namespace PlanarSystemWS.src.Domain.AddressManagement;

public interface IAddressRepository
{
    Task<RefAddress> FindById(Guid id);
    Task Update(RefAddress origin, RefAddress updated);
}
