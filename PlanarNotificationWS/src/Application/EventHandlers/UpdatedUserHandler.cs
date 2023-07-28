using AutoMapper;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class UpdatedUserHandler : IEventHandler<UpdatedUserEvent>
{
    private readonly INotificationService _notificationService;
    private readonly IMapper _mapper;

    public UpdatedUserHandler(INotificationService notificationService, IMapper mapper)
    {
        _notificationService = notificationService;
        _mapper = mapper;
    }

    public async Task HandleEvent(UpdatedUserEvent @event)
    {
        try
        {
            var userMap = _mapper.Map<User>(@event);

            await _notificationService.UpdateUser(userMap);
        }
        catch (Exception ex) { throw; }
    }
}