using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Application.UserManagement;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

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
