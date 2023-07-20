using MongoDB.Bson;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public class ActivityRepository : IActivityRepository
{
    // ...

    public Task SaveActivity(Activity activity)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Activity>> FindActivitiesByUserId(ObjectId userId)
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
