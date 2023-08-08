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
}