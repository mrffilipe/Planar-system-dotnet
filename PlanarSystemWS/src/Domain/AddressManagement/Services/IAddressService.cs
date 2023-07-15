namespace PlanarSystemWS.src.Domain.AddressManagement;

public interface IAddressService
{
    void Save(RefAddress address);
    RefAddress FindById(string id);
    void Update(RefAddress address);
}