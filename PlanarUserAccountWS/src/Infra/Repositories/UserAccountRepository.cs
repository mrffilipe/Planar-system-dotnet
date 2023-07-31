using Microsoft.EntityFrameworkCore;
using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Infra;

public class UserAccountRepository : IUserAccountRepository
{
    private readonly MySqlDbContext _context;

    public UserAccountRepository(MySqlDbContext context)
    {
        _context = context;
    }

    public async Task<User> RegisterUser(User user)
    {
        try
        {
            await _context.Users.AddAsync(user);

            await _context.SaveChangesAsync();

            return user;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<User?> FindUserById(Guid id)
    {
        try
        {
            var user = await _context.Users
                .Include(x => x.Claims)
                .FirstOrDefaultAsync(x => x.Id.Equals(id));

            return user;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<ICollection<User>> FindAllUsers()
    {
        try
        {
            var users = await _context.Users
                .Include(x => x.Claims)
                .ToListAsync();

            return users;
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateUser(User user)
    {
        try
        {
            _context.Attach(user);
            _context.Entry(user).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
        catch (Exception ex) { throw; }
    }

    public async Task AddClaimToUser(RefUserClaim claim)
    {
        try
        {
            await _context.UserClaim.AddAsync(claim);

            await _context.SaveChangesAsync();
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateUserClaim(RefUserClaim claim)
    {
        try
        {
            _context.Attach(claim);
            _context.Entry(claim).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
        catch (Exception ex) { throw; }
    }

    public async Task RemoveUserClaim(RefUserClaim claim)
    {
        try
        {
            _context.UserClaim.Remove(claim);

            await _context.SaveChangesAsync();
        }
        catch (Exception ex) { throw; }
    }
}