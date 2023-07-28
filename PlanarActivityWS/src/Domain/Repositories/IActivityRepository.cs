namespace PlanarActivityWS.src.Domain;

public interface IActivityRepository
{
    Task SaveActivity(Activity activity);
    Task<IList<Activity>> FindActivitiesByUserId(string userAccountId);
    Task UpdateActivity(Activity activity);
    Task SaveUser(User user);
    Task UpdateUser(User user);
}