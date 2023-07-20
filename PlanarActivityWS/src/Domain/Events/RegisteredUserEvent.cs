namespace PlanarActivityWS.src.Domain;

public class RegisteredUserEvent : BaseEvent
{
    public string Queue { get; set; } = "teste";
}