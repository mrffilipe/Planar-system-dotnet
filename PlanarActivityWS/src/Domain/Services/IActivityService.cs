namespace PlanarActivityWS.src.Domain;

public interface IActivityService
{
    Task SaveActivity(Activity activity);
    Task<IList<Activity>> FindActivities();
    Task UpdateActivity(Activity activity);
    Task SaveUser(User user);
    Task UpdateUser(User user);
}