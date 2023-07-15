namespace PlanarSystemWS.src.Domain.AddressManagement;

public interface IAddressRepository
{
    void Save(RefAddress address);
    RefAddress FindById(string id);
    void Update(RefAddress address);
}
