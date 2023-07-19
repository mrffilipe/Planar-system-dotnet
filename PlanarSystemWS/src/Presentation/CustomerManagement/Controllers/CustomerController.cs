using Microsoft.AspNetCore.Mvc;
using PlanarSystemWS.src.Application.CustomerManagement;
using PlanarSystemWS.src.Presentation.Shared.Controllers;

namespace PlanarSystemWS.src.Presentation.CustomerManagement.Controllers;

public class CustomerController : BaseController
{
    private readonly ICustomerAdapter _customerAdapter;

    public CustomerController(ICustomerAdapter customerAdapter)
    {
        _customerAdapter = customerAdapter;
    }

    [HttpPost]
    public async Task Save([FromBody] CustomerRegistrationDTO customer)
    {
        await _customerAdapter.Save(customer);
    }

    [HttpGet]
    public async Task<DetailedReplyCustomerDTO> FindById([FromQuery] Guid id)
    {
        var res = await _customerAdapter.FindById(id);

        return res;
    }

    //[HttpPost]
    //public async Task Update()
    //{

    //}
}