using AutoMapper;
using MongoDB.Bson;
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

    public Task SaveNotification(NotificationRegistrationDTO notification)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<ReplyNotificationDTO>> FindNotificationsByUserId(ObjectId id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateNotification(NotificationRegistrationDTO notification)
    {
        throw new NotImplementedException();
    }

    public Task SaveUser(UserRegistrationDTO user)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUser(UserRegistrationDTO user)
    {
        throw new NotImplementedException();
    }
}
