using PlanarSystemWS.src.Domain.AddressManagement;

namespace PlanarSystemWS.src.Domain.CustomerManagement;

public interface ICustomerService
{
    Task Save(Customer customer);
    Task<Customer> FindById(Guid id);
    Task Update(Customer origin, Customer updated);
    Task UpdateDocument(RefDocument document);
    Task UpdatePhone(RefPhone phone);
    Task UpdateAddress(RefAddress address);
}