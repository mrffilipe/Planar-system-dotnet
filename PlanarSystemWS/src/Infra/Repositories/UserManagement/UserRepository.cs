using Microsoft.EntityFrameworkCore;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Infra.Repositories.UserManagement;

public class UserRepository : IUserRepository
{
    private readonly MySqlDbContext _context;

    public UserRepository(MySqlDbContext context)
    {
        _context = context;
    }

    public async Task Register(User user)
    {
        try
        {
            await _context.AddAsync(user);

            await _context.SaveChangesAsync();
        }
        catch (Exception ex) { throw; }
    }

    public async Task<User> FindById(Guid id)
    {
        try
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Id.Equals(id));

            return user;
        }
        catch (Exception ex) { throw; }
    }

    public async Task Update(User origin, User updated)
    {
        try
        {
            _context.Attach(origin);
            _context.Entry(updated).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
        catch (Exception ex) { throw; }
    }
}
