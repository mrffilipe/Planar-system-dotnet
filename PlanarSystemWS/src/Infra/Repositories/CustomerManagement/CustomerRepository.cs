using PlanarSystemWS.src.Domain.AddressManagement;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Infra.Repositories.CustomerManagement;

public class CustomerRepository : ICustomerRepository
{
    // ...

    public Task Save(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Task<Customer> FindById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Update(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Task UpdateDocument(RefDocument document)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePhone(RefPhone phone)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAddress(RefAddress address)
    {
        throw new NotImplementedException();
    }
}
