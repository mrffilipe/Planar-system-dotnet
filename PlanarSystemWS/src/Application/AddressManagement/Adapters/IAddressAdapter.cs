namespace PlanarSystemWS.src.Application.AddressManagement;

public interface IAddressAdapter
{
    Task Save(AddressRegistrationDTO address);
    Task<DetailedReplyAddressDTO> FindById(Guid id);
    Task Update(AddressRegistrationDTO origin, AddressRegistrationDTO updated);
}
