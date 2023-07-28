using PlanarActivityWS.src.Domain;

namespace PlanarActivityWS.src.Application;

public class ReplyActivityDTO : IEntityDTO
{
    public string Id { get; set; }
    public ActivityRelationship Relationship { get; set; }
    public ActivityStatus Status { get; set; }
    public string UserAccountId { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}