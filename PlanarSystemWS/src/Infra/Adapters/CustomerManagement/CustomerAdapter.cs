using AutoMapper;
using PlanarSystemWS.src.Application.AddressManagement;
using PlanarSystemWS.src.Application.CustomerManagement;
using PlanarSystemWS.src.Domain.CustomerManagement;

namespace PlanarSystemWS.src.Infra.Adapters.CustomerManagement;

public class CustomerAdapter : ICustomerAdapter
{
    private readonly ICustomerService _customerService;
    private readonly IMapper _mapper;

    public CustomerAdapter(ICustomerService customerService, IMapper mapper)
    {
        _customerService = customerService;
        _mapper = mapper;
    }

    public async Task Save(CustomerRegistrationDTO customer)
    {
        try
        {
            var customerMap = _mapper.Map<Customer>(customer);

            await _customerService.Save(customerMap);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<ReplyCustomerDTO> FindById(Guid id)
    {
        try
        {
            var customer = await _customerService.FindById(id);

            return _mapper.Map<ReplyCustomerDTO>(customer);
        }
        catch (Exception ex) { throw; }
    }

    public async Task Update(CustomerRegistrationDTO origin, CustomerRegistrationDTO updated)
    {
        try
        {
            var originMap = _mapper.Map<Customer>(origin);
            var updatedMap = _mapper.Map<Customer>(updated);

            await _customerService.Update(originMap, updatedMap);
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateAddress(AddressRegistrationDTO address)
    {
        try
        {

        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateDocument(DocumentRegistrationDTO document)
    {
        try
        {

        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdatePhone(PhoneRegistrationDTO phone)
    {
        try
        {

        }
        catch (Exception ex) { throw; }
    }
}
