using AutoMapper;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

public class UpdatedActivityHandler : IEventHandler<UpdatedActivityEvent>
{
    private readonly IActivityService _activityService;
    private readonly IMapper _mapper;

    public UpdatedActivityHandler(IActivityService activityService, IMapper mapper)
    {
        _activityService = activityService;
        _mapper = mapper;
    }

    public async Task HandleEvent(UpdatedActivityEvent @event)
    {
        try
        {
            var activityMap = _mapper.Map<Activity>(@event);

            await _activityService.UpdateActivity(activityMap);
        }
        catch (Exception ex) { throw; }
    }
}