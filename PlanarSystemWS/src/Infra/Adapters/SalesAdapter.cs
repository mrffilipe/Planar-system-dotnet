using AutoMapper;
using PlanarSalesWS.src.Application;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Infra;

public class SalesAdapter : ISalesAdapter
{
    private readonly ISalesService _userService;
    private readonly IMapper _mapper;

    public SalesAdapter(ISalesService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    public async Task<SellerResponseDTO> FindSellerById(Guid id)
    {
        try
        {
            var seller = await _userService.FindSellerById(id);

            return _mapper.Map<SellerResponseDTO>(seller);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<CustomerResponseDTO> FindCustomerById(Guid id)
    {
        try
        {
            var customer = await _userService.FindCustomerById(id);

            return _mapper.Map<CustomerResponseDTO>(customer);
        }
        catch (Exception ex) { throw; }
    }
}