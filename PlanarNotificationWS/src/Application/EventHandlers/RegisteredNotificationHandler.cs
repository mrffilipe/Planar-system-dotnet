using AutoMapper;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class RegisteredNotificationHandler : IEventHandler<RegisteredNotificationEvent>
{
    private readonly INotificationService _notificationService;
    private readonly IMapper _mapper;

    public RegisteredNotificationHandler(INotificationService notificationService, IMapper mapper)
    {
        _notificationService = notificationService;
        _mapper = mapper;
    }

    public async Task HandleEvent(RegisteredNotificationEvent @event)
    {
        try
        {
            var notificationMap = _mapper.Map<Notification>(@event);

            await _notificationService.SaveNotification(notificationMap);
        }
        catch (Exception ex) { throw; }
    }
}