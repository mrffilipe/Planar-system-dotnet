using Microsoft.AspNetCore.Mvc;
using PlanarActivityWS.src.Application;
using PlanarActivityWS.src.Infra.Controllers;

namespace PlanarActivityWS.src.Presentation.Controllers;

public class ActivityController : BaseController
{
    private readonly IActivityAdapter _activityAdapter;

    public ActivityController(IActivityAdapter activityAdapter)
    {
        _activityAdapter = activityAdapter;
    }

    [HttpGet]
    [Route("find-activities")]
    public async Task<ICollection<ReplyActivityDTO>> FindActivities()
    {
        try
        {
            var activities = await _activityAdapter.FindActivities();

            return activities;
        }
        catch (Exception ex) { throw; }
    }
}
