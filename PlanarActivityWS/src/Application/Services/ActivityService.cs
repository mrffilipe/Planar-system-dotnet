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

        }
        catch (Exception ex) { throw; }
    }

    public async Task<ICollection<Activity>> FindActivities()
    {
        try
        {
            var activities = await _activityRepository.FindActivitiesByUserId("");

            return activities;
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateActivity(Activity activity)
    {
        try
        {

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

        }
        catch (Exception ex) { throw; }
    }
}