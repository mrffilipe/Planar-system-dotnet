namespace PlanarSystemWS.src.Application.AddressManagement;

public interface IAddressAdapter
{
    Task Save(AddressRegistrationDTO address);
    Task<ReplyAddressDTO> FindById(Guid id);
    Task Update(AddressRegistrationDTO address);
}
