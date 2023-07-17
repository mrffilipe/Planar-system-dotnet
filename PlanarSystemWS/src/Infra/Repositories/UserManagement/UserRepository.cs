using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Infra.Repositories.UserManagement;

public class UserRepository : IUserRepository
{
    // ...

    public async Task Register(User user)
    {
        throw new NotImplementedException();
    }

    public async Task<User> FindById(string id)
    {
        throw new NotImplementedException();
    }

    public async Task Update(User user)
    {
        throw new NotImplementedException();
    }
}
