using PlanarSystemWS.src.Application.AddressManagement;
using PlanarSystemWS.src.Application.Shared;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public class DetailedReplyCustomerDTO : IEntityDTO
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public ReplyDocumentDTO Document { get; set; }
    public ReplyPhoneDTO Phone { get; set; }
    public ReplyAddressDTO Address { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime UpdatedOn { get; set; }
}