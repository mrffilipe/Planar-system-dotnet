namespace PlanarActivityWS.src.Domain;

public class RegisteredUserEvent : BaseEvent
{
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public override string Queue { get; protected set; } = "new-registered-user";
    public override string Exchange { get; protected set; } = "ex";
    public override string RoutingKey { get; protected set; } = "";

    public RegisteredUserEvent(string userName, string email)
    {
        UserName = userName;
        Email = email;
    }
}