using PlanarChatMessagingWS.src.Domain;

namespace PlanarChatMessagingWS.src.Infra;

public class UserRepository : IUserRepository
{
    public Task<User> FindById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task Register(User user)
    {
        throw new NotImplementedException();
    }

    public Task Update(User origin, User updated)
    {
        throw new NotImplementedException();
    }
}