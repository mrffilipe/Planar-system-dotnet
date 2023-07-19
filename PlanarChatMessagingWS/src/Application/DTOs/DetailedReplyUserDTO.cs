namespace PlanarChatMessagingWS.src.Application;

public class DetailedReplyUserDTO : IEntityDTO
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}