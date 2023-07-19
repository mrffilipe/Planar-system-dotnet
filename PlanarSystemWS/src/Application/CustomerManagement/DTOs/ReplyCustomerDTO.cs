using PlanarSystemWS.src.Application.AddressManagement;
using PlanarSystemWS.src.Application.Shared;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public class ReplyCustomerDTO : IEntityDTO
{
    public Guid Id { get; set; }
    public ReplyDocumentDTO Document { get; private set; }
    public ReplyPhoneDTO Phone { get; private set; }
    public ReplyAddressDTO Address { get; private set; }
    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }
}
