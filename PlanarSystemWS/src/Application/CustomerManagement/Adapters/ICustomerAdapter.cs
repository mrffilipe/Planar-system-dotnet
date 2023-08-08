using PlanarSystemWS.src.Application.AddressManagement;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public interface ICustomerAdapter
{
    Task<DetailedReplyCustomerDTO> FindById(Guid id);
    Task Update(CustomerRegistrationDTO origin, CustomerRegistrationDTO updated);
    Task UpdateDocument(DocumentRegistrationDTO document);
    Task UpdatePhone(PhoneRegistrationDTO phone);
    Task UpdateAddress(AddressRegistrationDTO address);
}