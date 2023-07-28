using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

public class ActivityService : IActivityService
{
    private readonly IActivityRepository _activityRepository;

    public ActivityService(IActivityRepository activityRepository)
    {
        _activityRepository = activityRepository;
    }

    public async Task SaveActivity(Activity activity)
    {
        try
        {
            await _activityRepository.SaveActivity(activity);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<IList<Activity>> FindActivities()
    {
        try
        {
            var activities = await _activityRepository.FindActivitiesByUserId(""); // fornecer o id do identity

            return activities;
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateActivity(Activity activity)
    {
        try
        {
            await _activityRepository.UpdateActivity(activity);
        }
        catch (Exception ex) { throw; }
    }

    public async Task SaveUser(User user)
    {
        try
        {
            await _activityRepository.SaveUser(user);
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateUser(User user)
    {
        try
        {
            await _activityRepository.UpdateUser(user);
        }
        catch (Exception ex) { throw; }
    }
}