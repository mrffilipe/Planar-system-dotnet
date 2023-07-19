using AutoMapper;
using PlanarSystemWS.src.Application.AddressManagement;
using PlanarSystemWS.src.Domain.AddressManagement;

namespace PlanarSystemWS.src.Infra.Adapters.AddressManagement
{
    public class AddressAdapter : IAddressAdapter
    {
        private readonly IAddressService _addressService;
        private readonly IMapper _mapper;

        public AddressAdapter(IAddressService addressService, IMapper mapper)
        {
            _addressService = addressService;
            _mapper = mapper;
        }

        public async Task Save(AddressRegistrationDTO address)
        {
            try
            {
                var addressMap = _mapper.Map<RefAddress>(address);

                await _addressService.Save(addressMap);
            }
            catch (Exception ex) { throw; }
        }

        public async Task<DetailedReplyAddressDTO> FindById(Guid id)
        {
            try
            {
                var address = await _addressService.FindById(id);

                return _mapper.Map<DetailedReplyAddressDTO>(address);
            }
            catch (Exception ex) { throw; }
        }

        public async Task Update(AddressRegistrationDTO origin, AddressRegistrationDTO updated)
        {
            try
            {
                var originMap = _mapper.Map<RefAddress>(updated);
                var updatedMap = _mapper.Map<RefAddress>(updated);

                await _addressService.Update(originMap, updatedMap);
            }
            catch (Exception ex) { throw; }
        }
    }
}
