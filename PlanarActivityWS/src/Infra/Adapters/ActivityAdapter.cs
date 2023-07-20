using PlanarActivityWS.src.Application;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public class ActivityAdapter : IActivityAdapter
{
    private readonly IActivityService _activityService;

    public ActivityAdapter(IActivityService activityService)
    {
        _activityService = activityService;
    }

    public Task SaveActivity(ActivityRegistrationDTO activity)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<ReplyActivityDTO>> FindActivities()
    {
        throw new NotImplementedException();
    }

    public Task UpdateActivity(ActivityRegistrationDTO activity)
    {
        throw new NotImplementedException();
    }

    public Task SaveUser(UserRegistrationDTO user)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUser(UserRegistrationDTO user)
    {
        throw new NotImplementedException();
    }
}
