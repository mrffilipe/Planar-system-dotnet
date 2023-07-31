using Microsoft.AspNetCore.SignalR;

namespace PlanarChatMessagingWS.TstChat;

public class ChatHub : Hub
{
    public async Task SendMessage(string text)
    {
        await Clients.All.SendAsync(text);

    }
}