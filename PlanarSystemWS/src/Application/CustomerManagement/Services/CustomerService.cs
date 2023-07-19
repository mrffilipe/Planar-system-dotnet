using PlanarSystemWS.src.Domain.AddressManagement;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

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