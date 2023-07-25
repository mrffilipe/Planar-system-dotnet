using MongoDB.Bson;
using MongoDB.Driver;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public class ActivityRepository : IActivityRepository
{
    private readonly IMongoClient _client;
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<Activity> _activity;
    private readonly IMongoCollection<User> _user;

    public ActivityRepository(IMongoClient client)
    {
        _client = client;
        _database = _client.GetDatabase("planar-activity-db");

        _activity = _database.GetCollection<Activity>("activity-collection");
        _user = _database.GetCollection<User>("user-collection");
    }

    public async Task SaveActivity(Activity activity)
    {
        throw new NotImplementedException();
    }

    public async Task<ICollection<Activity>> FindActivitiesByUserId(ObjectId userId)
    {
        try
        {
            var filter = Builders<Activity>.Filter
                .Eq(x => x.UserId, userId);

            var activities = await _activity.Find(filter)
                .ToListAsync();

            return activities;
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateActivity(Activity activity)
    {
        throw new NotImplementedException();
    }

    public async Task SaveUser(User user)
    {
        throw new NotImplementedException();
    }

    public async Task UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}
