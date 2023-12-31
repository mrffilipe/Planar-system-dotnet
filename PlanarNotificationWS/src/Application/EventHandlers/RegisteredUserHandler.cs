﻿using AutoMapper;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class RegisteredUserHandler : IEventHandler<RegisteredUserEvent>
{
    private readonly INotificationService _notificationService;
    private readonly IMapper _mapper;

    public RegisteredUserHandler(INotificationService notificationService, IMapper mapper)
    {
        _notificationService = notificationService;
        _mapper = mapper;
    }

    public async Task HandleEvent(RegisteredUserEvent @event)
    {
        try
        {
            var userMap = _mapper.Map<User>(@event);

            await _notificationService.SaveUser(userMap);
        }
        catch (Exception ex) { throw; }
    }
}