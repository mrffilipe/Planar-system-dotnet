using PlanarSystemWS.src.Application.Shared;

namespace PlanarSystemWS.src.Application.UserManagement;

public class ReplyUserDTO : IEntityDTO
{
    public Guid Id { get; set; }
    public string UserName { get; private set; }
    public string Email { get; private set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}