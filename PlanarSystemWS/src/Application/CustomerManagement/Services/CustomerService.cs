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

    public async Task Save(Customer customer)
    {
        try
        {
            await _customerRepository.Save(customer);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<Customer> FindById(Guid id)
    {
        try
        {
            var customer = await _customerRepository.FindById(id);

            return customer;
        }
        catch (Exception ex) { throw; }
    }

    public async Task Update(Customer origin, Customer updated)
    {
        try
        {
            if (origin != null && updated != null)
            {
                await _customerRepository.Update(origin, updated);
            }
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateDocument(RefDocument document)
    {
        try
        {

        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdatePhone(RefPhone phone)
    {
        try
        {

        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateAddress(RefAddress address)
    {
        try
        {

        }
        catch (Exception ex) { throw; }
    }
}