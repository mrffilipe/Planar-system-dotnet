using AutoMapper;
using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

public class UpdatedUserHandler : IEventHandler<UpdatedUserEvent>
{
    private readonly IActivityService _activityService;
    private readonly IMapper _mapper;

    public UpdatedUserHandler(IActivityService activityService, IMapper mapper)
    {
        _activityService = activityService;
        _mapper = mapper;
    }

    public async Task HandleEvent(UpdatedUserEvent @event)
    {
        try
        {
            var userMap = _mapper.Map<User>(@event);

            await _activityService.UpdateUser(userMap);
        }
        catch (Exception ex) { throw; }
    }
}