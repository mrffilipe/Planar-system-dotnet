using MongoDB.Bson;
using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Infra;

public class UserAccountRepository : IUserAccountRepository
{
    // ...

    public Task RegisterUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task<User> FindUserById(ObjectId id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<User>> FindAllUsers()
    {
        throw new NotImplementedException();
    }

    public Task UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}