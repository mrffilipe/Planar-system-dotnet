using PlanarSystemWS.src.Domain.ActivityManagement;

namespace PlanarSystemWS.src.Application.ActivityManagement;

public class ActivityService : IActivityService
{
    private readonly IActivityRepository _activityRepository;

    public ActivityService(IActivityRepository activityRepository)
    {
        _activityRepository = activityRepository;
    }

    public void Save(Activity activity)
    {
        throw new NotImplementedException();
    }

    public Activity FindById(string id)
    {
        throw new NotImplementedException();
    }

    public void Update(Activity activity)
    {
        throw new NotImplementedException();
    }
}