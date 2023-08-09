using Microsoft.AspNetCore.Mvc;
using PlanarSalesWS.src.Application;

namespace PlanarSalesWS.src.Presentation;

public class SalesController : BaseController
{
    private readonly ISalesAdapter _saleAdapter;

    public SalesController(ISalesAdapter saleAdapter)
    {
        _saleAdapter = saleAdapter;
    }

    [HttpGet]
    [Route("find-seller-by-id")]
    public async Task<ActionResult<SellerResponseDTO>> FindSellerById([FromQuery] Guid id)
    {
        try
        {
            var seller = await _saleAdapter.FindSellerById(id);

            return Ok(seller);
        }
        catch (Exception ex) { throw; }
    }

    [HttpGet]
    [Route("find-customer-by-id")]
    public async Task<ActionResult<CustomerResponseDTO>> FindCustomerById([FromQuery] Guid id)
    {
        try
        {
            var customer = await _saleAdapter.FindCustomerById(id);

            return Ok(customer);
        }
        catch (Exception ex) { throw; }
    }
}