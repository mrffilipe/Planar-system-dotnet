using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

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