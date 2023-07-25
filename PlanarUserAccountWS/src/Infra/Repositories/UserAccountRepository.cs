using MongoDB.Bson;
using MongoDB.Driver;
using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Infra;

public class UserAccountRepository : IUserAccountRepository
{
    private readonly IMongoClient _client;
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<User> _users;

    public UserAccountRepository(IMongoClient client)
    {
        _client = client;
        _database = _client.GetDatabase("planar-user-account-db");
        _users = _database.GetCollection<User>("user-collection");
    }

    public async Task RegisterUser(User user)
    {
        try
        {
            await _users.InsertOneAsync(user);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<User> FindUserById(string id)
    {
        try
        {
            var filter = Builders<User>.Filter
                .Eq(x => x.Id, ObjectId.Parse(id));

            var user = await _users.Find(filter)
                .FirstOrDefaultAsync();

            return user;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<ICollection<User>> FindAllUsers()
    {
        try
        {
            var users = await _users.AsQueryable()
                .ToListAsync();

            return users;
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