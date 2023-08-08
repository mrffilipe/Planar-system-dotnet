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
}