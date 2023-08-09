using Microsoft.EntityFrameworkCore;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

public class SalesRepository : ISalesRepository
{
    private readonly MySqlDbContext _context;

    public SalesRepository(MySqlDbContext context)
    {
        _context = context;
    }

    public async Task<Seller> RegisterSeller(Seller seller)
    {
        try
        {
            await _context.Sellers
                .AddAsync(seller);

            await _context.SaveChangesAsync();

            return seller;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<Seller> FindSellerById(Guid id)
    {
        try
        {
            var result = await _context.Sellers
                .FirstOrDefaultAsync(x => x.Id.Equals(id));

            return result;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<Seller> UpdateSeller(Seller origin, Seller updated)
    {
        try
        {
            _context.Attach(origin);
            _context.Entry(updated).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return updated;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<Customer> FindCustomerById(Guid id)
    {
        try
        {
            var result = await _context.Customers
                .FirstOrDefaultAsync(x => x.Id.Equals(id));

            return result;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<Customer> UpdateCustomer(Customer origin, Customer updated)
    {
        try
        {
            _context.Attach(origin);
            _context.Entry(updated).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return updated;
        }
        catch (Exception ex) { throw; }
    }
}