using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Application;

public class UserRegistrationDTO
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public Phone Phone { get; set; }
}