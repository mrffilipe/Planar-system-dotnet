namespace PlanarSystemWS.src.Domain.AddressManagement;

public interface IAddressService
{
    Task<RefAddress> FindById(Guid id);
    Task Update(RefAddress origin, RefAddress updated);
}