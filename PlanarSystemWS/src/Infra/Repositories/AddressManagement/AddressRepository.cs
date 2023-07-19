using Microsoft.EntityFrameworkCore;
using PlanarSystemWS.src.Domain.AddressManagement;

namespace PlanarSystemWS.src.Infra.Repositories.AddressManagement;

public class AddressRepository : IAddressRepository
{
    private readonly MySqlDbContext _context;

    public AddressRepository(MySqlDbContext context)
    {
        _context = context;
    }

    public async Task Save(RefAddress address)
    {
        try
        {
            await _context.Adresses
                .AddAsync(address);

            await _context.SaveChangesAsync();
        }
        catch (Exception ex) { throw; }
    }

    public async Task<RefAddress> FindById(Guid id)
    {
        try
        {
            var address = await _context.Adresses
                .FirstOrDefaultAsync(x => x.Id.Equals(id));

            return address;
        }
        catch (Exception ex) { throw; }
    }

    public async Task Update(RefAddress origin, RefAddress updated)
    {
        try
        {
            _context.Attach(updated);
            _context.Entry(updated).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
        catch (Exception ex) { throw; }
    }
}
