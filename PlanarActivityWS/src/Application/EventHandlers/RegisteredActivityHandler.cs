using AutoMapper;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

public class RegisteredActivityHandler : IEventHandler<RegisteredActivityEvent>
{
    private readonly IActivityService _activityService;
    private readonly IMapper _mapper;

    public RegisteredActivityHandler(IActivityService activityService, IMapper mapper)
    {
        _activityService = activityService;
        _mapper = mapper;
    }

    public async Task HandleEvent(RegisteredActivityEvent @event)
    {
        try
        {
            var activityMap = _mapper.Map<Activity>(@event);

            await _activityService.SaveActivity(activityMap);
        }
        catch (Exception ex) { throw; }
    }
}