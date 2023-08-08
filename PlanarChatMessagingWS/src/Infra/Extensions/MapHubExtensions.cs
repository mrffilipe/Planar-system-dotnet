using PlanarChatMessagingWS.src.Presentation;

namespace PlanarChatMessagingWS.src.Infra;

public static class MapHubExtensions
{
    public static IEndpointRouteBuilder MapHubs(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapHub<ChatHub>("/hubs/chat");

        return endpoints;
    }
}