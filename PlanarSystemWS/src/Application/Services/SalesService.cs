using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public class SalesService : ISalesService
{
    private readonly ISalesRepository _userRepository;

    public SalesService(ISalesRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Seller> RegisterSeller(Seller seller)
    {
        try
        {
            var result = await _userRepository.RegisterSeller(seller);

            return result;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<Seller> FindSellerById(Guid id)
    {
        try
        {
            var result = await _userRepository.FindSellerById(id);

            return result;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<Seller> UpdateSeller(Seller origin, Seller updated)
    {
        try
        {
            var result = await _userRepository.UpdateSeller(origin, updated);

            return result;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<Customer> FindCustomerById(Guid id)
    {
        try
        {
            var result = await _userRepository.FindCustomerById(id);

            return result;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<Customer> UpdateCustomer(Customer origin, Customer updated)
    {
        try
        {
            var result = await _userRepository.UpdateCustomer(origin, updated);

            return result;
        }
        catch (Exception ex) { throw; }
    }
}