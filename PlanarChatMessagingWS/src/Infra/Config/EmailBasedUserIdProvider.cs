using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;

namespace PlanarChatMessagingWS.src.Infra;

public class EmailBasedUserIdProvider : IUserIdProvider
{
    public string? GetUserId(HubConnectionContext connection)
    {
        try
        {
            return connection.User?.FindFirst(ClaimTypes.Email)?.Value!;
        }
        catch (Exception ex) { throw; }
    }
}