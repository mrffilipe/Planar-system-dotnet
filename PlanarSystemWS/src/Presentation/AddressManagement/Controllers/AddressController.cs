using Microsoft.AspNetCore.Mvc;
using PlanarSystemWS.src.Application.AddressManagement;
using PlanarSystemWS.src.Presentation.Shared.Controllers;

namespace PlanarSystemWS.src.Presentation.AddressManagement.Controllers;

public class AddressController : BaseController
{
    private readonly IAddressAdapter _addressAdapter;

    public AddressController(IAddressAdapter addressAdapter)
    {
        _addressAdapter = addressAdapter;
    }

    [HttpPost]
    public async Task Save([FromBody] AddressRegistrationDTO address)
    {
        await _addressAdapter.Save(address);
    }

    [HttpGet]
    public async Task<DetailedReplyAddressDTO> FindById([FromQuery] Guid id)
    {
        var res = await _addressAdapter.FindById(id);

        return res;
    }

    //[HttpPost]
    //public async Task Update()
    //{

    //}
}