using PlanarSystemWS.src.Application.AddressManagement;

namespace PlanarSystemWS.src.Application.CustomerManagement;

public interface ICustomerAdapter
{
    Task Save(CustomerRegistrationDTO customer);
    Task<ReplyCustomerDTO> FindById(Guid id);
    Task Update(CustomerRegistrationDTO customer);
    Task UpdateDocument(DocumentRegistrationDTO document);
    Task UpdatePhone(PhoneRegistrationDTO phone);
    Task UpdateAddress(AddressRegistrationDTO address);
}