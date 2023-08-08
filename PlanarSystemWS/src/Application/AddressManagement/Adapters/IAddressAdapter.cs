namespace PlanarSystemWS.src.Application.AddressManagement;

public interface IAddressAdapter
{
    Task<DetailedReplyAddressDTO> FindById(Guid id);
    Task Update(AddressRegistrationDTO origin, AddressRegistrationDTO updated);
}