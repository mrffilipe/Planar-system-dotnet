using MongoDB.Bson;

namespace PlanarActivityWS.src.Domain;

public interface IActivityRepository
{
    Task SaveActivity(Activity activity);
    Task<ICollection<Activity>> FindActivitiesByUserId(ObjectId userId);
    Task UpdateActivity(Activity activity);
    Task SaveUser(User user);
    Task UpdateUser(User user);
}