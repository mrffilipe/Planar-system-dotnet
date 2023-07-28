using AutoMapper;
using PlanarActivityWS.src.Application;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Infra;

public class ActivityAdapter : IActivityAdapter
{
    private readonly IActivityService _activityService;
    private readonly IMapper _mapper;

    public ActivityAdapter(IActivityService activityService, IMapper mapper)
    {
        _activityService = activityService;
        _mapper = mapper;
    }

    public async Task<IList<ReplyActivityDTO>> FindActivities()
    {
        try
        {
            var activities = await _activityService.FindActivities();

            return _mapper.Map<IList<ReplyActivityDTO>>(activities);
        }
        catch (Exception ex) { throw; }
    }
}
