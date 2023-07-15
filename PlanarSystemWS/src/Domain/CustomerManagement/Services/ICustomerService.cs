using PlanarSystemWS.src.Domain.AddressManagement;

namespace PlanarSystemWS.src.Domain.CustomerManagement;

public interface ICustomerService
{
    void Save(Customer customer);
    Customer FindById(string id);
    void Update(Customer customer);
    void UpdateDocument(RefDocument document);
    void UpdatePhone(RefPhone phone);
    void UpdateAddress(RefAddress address);
}