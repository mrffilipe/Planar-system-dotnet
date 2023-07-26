using AutoMapper;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

public class RegisteredUserHandler : IEventHandler<RegisteredUserEvent>
{
    private readonly IActivityService _activityService;
    private readonly IMapper _mapper;

    public RegisteredUserHandler(IActivityService activityService, IMapper mapper)
    {
        _activityService = activityService;
        _mapper = mapper;
    }

    public async Task HandleEvent(RegisteredUserEvent @event)
    {
        try
        {
            var userMap = _mapper.Map<User>(@event);
            
            await _activityService.SaveUser(userMap);
        }
        catch (Exception ex) { throw; }
    }
}