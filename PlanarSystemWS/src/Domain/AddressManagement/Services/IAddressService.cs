namespace PlanarSystemWS.src.Domain.AddressManagement;

public interface IAddressService
{
    Task Save(RefAddress address);
    Task<RefAddress> FindById(Guid id);
    Task Update(RefAddress address);
}