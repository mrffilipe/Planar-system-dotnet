using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

public class ActivityService : IActivityService
{
    private readonly IActivityRepository _activityRepository;

    public ActivityService(IActivityRepository activityRepository)
    {
        _activityRepository = activityRepository;
    }

    public Task SaveActivity(Activity activity)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Activity>> FindActivities()
    {
        throw new NotImplementedException();
    }

    public Task UpdateActivity(Activity activity)
    {
        throw new NotImplementedException();
    }

    public Task SaveUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}