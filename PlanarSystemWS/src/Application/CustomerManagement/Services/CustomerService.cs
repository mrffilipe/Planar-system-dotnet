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

    public void Save(Customer customer)
    {
        throw new NotImplementedException();
    }

    public Customer FindById(string id)
    {
        throw new NotImplementedException();
    }

    public void Update(Customer customer)
    {
        throw new NotImplementedException();
    }

    public void UpdateDocument(RefDocument document)
    {
        throw new NotImplementedException();
    }

    public void UpdatePhone(RefPhone phone)
    {
        throw new NotImplementedException();
    }

    public void UpdateAddress(RefAddress address)
    {
        throw new NotImplementedException();
    }
}