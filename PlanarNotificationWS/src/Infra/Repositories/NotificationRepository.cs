using MongoDB.Driver;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Infra;

public class NotificationRepository : INotificationRepository
{
    private readonly IMongoClient _client;
    private readonly IMongoDatabase _database;
    private readonly IMongoCollection<User> _user;

    public NotificationRepository(IMongoClient client)
    {
        _client = client;

        _database = _client.GetDatabase("planar-notification-db");
        _user = _database.GetCollection<User>("user-collection");
    }

    public async Task SaveNotification(Notification notification)
    {
        try
        {
            var filter = Builders<User>.Filter
                .Eq(x => x.UserAccountId, notification.UserAccountId);

            var update = Builders<User>.Update
                .Push(x => x.Notifications, notification);

            await _user.UpdateOneAsync(filter, update);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<IList<Notification>> FindNotificationsByUserId(string userAccountId)
    {
        try
        {
            var filter = Builders<User>.Filter
                .Eq(x => x.UserAccountId, userAccountId);

            var user = await _user.Find(filter).FirstOrDefaultAsync();

            if (user != null)
            {
                var notifications = user.Notifications.ToList();

                return notifications;
            }

            throw new Exception();
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateNotification(Notification notification)
    {
        try
        {
            var filter = Builders<User>.Filter.And(
                Builders<User>.Filter
                    .Eq(x => x.UserAccountId, notification.UserAccountId),
                Builders<User>.Filter
                    .ElemMatch(x => x.Notifications,
                        a => a.Relationship.RelationshipId.Equals(notification.Relationship.RelationshipId))
            );

            var update = Builders<User>.Update
                .Set(x => x.Notifications[-1], notification);

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
                .Include(x => x.LastName)
                .Include(x => x.Email)
                .Include(x => x.Phone);

            var oldUser = await _user.Find(filter).Project<User>(projection).FirstOrDefaultAsync();

            if (oldUser != null)
            {
                var update = Builders<User>.Update
                    .Set(x => x.FirstName, user.FirstName)
                    .Set(x => x.LastName, user.LastName)
                    .Set(x => x.Email, user.Email)
                    .Set(x => x.Phone, user.Phone);

                await _user.UpdateOneAsync(filter, update);
            }
        }
        catch (Exception ex) { throw; }
    }
}