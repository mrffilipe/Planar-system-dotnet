﻿namespace PlanarNotificationWS.src.Domain;

public class RegisteredUserEvent : IEvent
{
    public string UserAccountId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public Phone Phone { get; set; }
    public string Queue => "new-registered-user";
    public string Exchange => "ex";
    public string RoutingKey => "";
}