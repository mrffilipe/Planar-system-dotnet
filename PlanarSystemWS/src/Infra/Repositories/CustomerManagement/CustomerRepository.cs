using Microsoft.EntityFrameworkCore;
using PlanarSystemWS.src.Domain.AddressManagement;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Infra.Repositories.CustomerManagement;

public class CustomerRepository : ICustomerRepository
{
    private readonly MySqlDbContext _context;

    public CustomerRepository(MySqlDbContext context)
    {
        _context = context;
    }

    public async Task<Customer> FindById(Guid id)
    {
        try
        {
            var customer = await _context.Customers
                .Include(x => x.Document)
                .Include(x => x.Phone)
                .Include(x => x.Address)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));

            return customer;
        }
        catch (Exception ex) { throw; }
    }

    public async Task Update(Customer origin, Customer updated)
    {
        try
        {
            _context.Attach(updated);
            _context.Entry(updated).State = EntityState.Modified;

            await _context.SaveChangesAsync();
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
        throw new NotImplementedException();
    }

    public async Task UpdateAddress(RefAddress address)
    {
        try
        {

        }
        catch (Exception ex) { throw; }
    }
}
