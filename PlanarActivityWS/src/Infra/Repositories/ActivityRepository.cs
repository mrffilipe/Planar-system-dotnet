using MongoDB.Driver;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public class ActivityRepository : IActivityRepository
{
    private readonly IMongoClient _client;
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<User> _user;

    public ActivityRepository(IMongoClient client)
    {
        _client = client;

        _database = _client.GetDatabase("planar-activity-db");
        _user = _database.GetCollection<User>("user-collection");
    }

    public async Task SaveActivity(Activity activity)
    {
        try
        {
            var filter = Builders<User>.Filter
                .Eq(x => x.UserAccountId, activity.UserAccountId);

            var update = Builders<User>.Update
                .Push(x => x.Activities, activity);

            await _user.UpdateOneAsync(filter, update);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<IList<Activity>> FindActivitiesByUserId(string userAccountId)
    {
        try
        {
            var filter = Builders<User>.Filter
                .Eq(x => x.UserAccountId, userAccountId);

            var user = await _user.Find(filter).FirstOrDefaultAsync();

            if (user != null)
            {
                var activities = user.Activities.ToList();

                return activities;
            }

            throw new Exception();
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateActivity(Activity activity)
    {
        try
        {
            var filter = Builders<User>.Filter.And(
                Builders<User>.Filter
                    .Eq(x => x.UserAccountId, activity.UserAccountId),
                Builders<User>.Filter
                    .ElemMatch(x => x.Activities,
                        a => a.Relationship.RelationshipId.Equals(activity.Relationship.RelationshipId))
            );

            var update = Builders<User>.Update
                .Set(x => x.Activities[-1], activity);

            await _user.UpdateOneAsync(filter, update);
        }
        catch (Exception ex) { throw; }
    }

    public async Task SaveUser(User user)
    {
        try
        {
            await _user.InsertOneAsync(user);
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateUser(User user)
    {
        try
        {
            var filter = Builders<User>.Filter
                .Eq(x => x.UserAccountId, user.UserAccountId);

            var projection = Builders<User>.Projection
                .Include(x => x.FirstName)
                .Include(x => x.LastName);

            var oldUser = await _user.Find(filter).Project<User>(projection).FirstOrDefaultAsync();

            if (oldUser != null)
            {
                var update = Builders<User>.Update
                    .Set(x => x.FirstName, user.FirstName)
                    .Set(x => x.LastName, user.LastName);

                await _user.UpdateOneAsync(filter, update);
            }
        }
        catch (Exception ex) { throw; }
    }
}
