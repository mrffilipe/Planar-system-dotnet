namespace PlanarAuthenticationWS.src.Domain;

public class RegisteredUserEvent : IEvent
{
    public string UserAccountId { get; private set; }
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public string Queue => "new-registered-user";
    public string Exchange => "ex";
    public string RoutingKey => "";

    public RegisteredUserEvent(
        string userAccountid,
        string userName,
        string email
        )
    {
        UserAccountId = userAccountid;
        //UserName = userName;
        UserName = email;
        Email = email;
    }
}