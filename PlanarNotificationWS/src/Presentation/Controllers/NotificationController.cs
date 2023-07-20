using Microsoft.AspNetCore.Mvc;
using PlanarNotificationWS.src.Application;

namespace PlanarNotificationWS.src.Presentation.Controllers;

public class NotificationController : BaseController
{
    private readonly INotificationAdapter _notificationAdapter;

    public NotificationController(INotificationAdapter notificationAdapter)
    {
        _notificationAdapter = notificationAdapter;
    }

    [HttpGet]
    [Route("find-notifications")]
    public async Task<ICollection<ReplyNotificationDTO>> FindNotificationsByUserId()
    {
        try
        {
            var notifications = await _notificationAdapter.FindNotifications();

            return notifications;
        }
        catch (Exception ex) { throw; }
    }

    [HttpPut]
    [Route("update-notification")]
    public async Task UpdateNotification([FromBody] NotificationRegistrationDTO notification)
    {
        try
        {
            await _notificationAdapter.UpdateNotification(notification);
        }
        catch (Exception ex) { throw; }
    }
}
