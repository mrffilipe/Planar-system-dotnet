using PlanarSystemWS.src.Application.Shared;
using PlanarSystemWS.src.Domain.AddressManagement;

namespace PlanarSystemWS.src.Application.AddressManagement;

public class DetailedReplyAddressDTO : IEntityDTO
{
    public Guid Id { get; set; }
    public Address Address { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}