using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Infra;

public class UserAccountRepository : IUserAccountRepository
{
    // ...

    public async Task RegisterUser(User user)
    {
        try
        {

        }
        catch (Exception ex) { throw; }
    }

    public async Task<User> FindUserById(Guid id)
    {
        try
        {
            throw new Exception();
        }
        catch (Exception ex) { throw; }
    }

    public async Task<ICollection<User>> FindAllUsers()
    {
        try
        {
            throw new Exception();
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateUser(User user)
    {
        try
        {

        }
        catch (Exception ex) { throw; }
    }
}