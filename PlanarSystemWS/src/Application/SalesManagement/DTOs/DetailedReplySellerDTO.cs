using PlanarSystemWS.src.Application.Shared;
using PlanarSystemWS.src.Application.UserManagement;

namespace PlanarSystemWS.src.Application.SalesManagement;

public class DetailedReplySellerDTO : IEntityDTO
{
    public Guid Id { get; set; }
    public double SalesCommission { get; set; }
    public ReplyUserDTO User { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}