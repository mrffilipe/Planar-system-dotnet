using AutoMapper;
using PlanarNotificationWS.src.Application;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Infra;

public class NotificationAdapter : INotificationAdapter
{
    private readonly INotificationService _notificationService;
    private readonly IMapper _mapper;

    public NotificationAdapter(INotificationService notificationService, IMapper mapper)
    {
        _notificationService = notificationService;
        _mapper = mapper;
    }

    public async Task<IList<ReplyNotificationDTO>> FindNotifications()
    {
        try
        {
            var notifications = await _notificationService.FindNotificationsByUserId(); // id do identity

            return _mapper.Map<IList<ReplyNotificationDTO>>(notifications);
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateNotification(UpdateNotificationDTO notification)
    {
        try
        {
            var notificationMap = _mapper.Map<Notification>(notification);

            await _notificationService.UpdateNotification(notificationMap);
        }
        catch (Exception ex) { throw; }
    }
}
