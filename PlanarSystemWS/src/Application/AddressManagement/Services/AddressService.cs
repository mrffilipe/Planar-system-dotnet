using PlanarSystemWS.src.Domain.AddressManagement;

namespace PlanarSystemWS.src.Application.AddressManagement;

public class AddressService : IAddressService
{
    private readonly IAddressRepository _addressRepository;

    public AddressService(IAddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public async Task<RefAddress> FindById(Guid id)
    {
        try
        {
            var address = await _addressRepository.FindById(id);

            return address;
        }
        catch (Exception ex) { throw; }
    }

    public async Task Update(RefAddress origin, RefAddress updated)
    {
        try
        {
            if (origin != null && updated != null)
            {
                await _addressRepository.Update(origin, updated);
            }
        }
        catch (Exception ex) { throw; }
    }
}