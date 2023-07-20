using MongoDB.Bson;

namespace PlanarActivityWS.src.Domain;

public interface IActivityService
{
    Task SaveActivity(Activity activity);
    Task<ICollection<Activity>> FindActivities();
    Task UpdateActivity(Activity activity);
    Task SaveUser(User user);
    Task UpdateUser(User user);
}