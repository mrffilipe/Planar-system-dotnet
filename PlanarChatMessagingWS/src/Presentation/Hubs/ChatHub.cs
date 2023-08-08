using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace PlanarChatMessagingWS.src.Presentation;

[Authorize]
public class ChatHub : Hub
{
    public async Task SendMessage(string text)
    {
        await Clients.All.SendAsync(text);
    }

    public override async Task OnConnectedAsync()
    {
        await base.OnConnectedAsync();
    }
}