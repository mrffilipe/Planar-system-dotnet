using Microsoft.AspNetCore.Mvc;
using PlanarUserAccountWS.src.Application;
using PlanarUserAccountWS.src.Infra.Controllers;

namespace PlanarUserAccountWS.src.Presentation.Controllers;

public class UserAccountController : BaseController
{
    private readonly IUserAccountAdapter _userAccountAdapter;

    public UserAccountController(IUserAccountAdapter userAccountAdapter)
    {
        _userAccountAdapter = userAccountAdapter;
    }

    [HttpPost]
    [Route("register-user")]
    public async Task RegisterUser([FromBody] RegisterUserDTO user)
    {
        try
        {
            await _userAccountAdapter.RegisterUser(user);
        }
        catch (Exception ex) { throw; }
    }

    [HttpGet]
    [Route("find-user-by-id")]
    public async Task<ReplyUserDTO> FindUserById([FromQuery] Guid id)
    {
        try
        {
            var user = await _userAccountAdapter.FindUserById(id);

            return user;
        }
        catch (Exception ex) { throw; }
    }

    [HttpGet]
    [Route("find-all-users")]
    public async Task<ICollection<ReplyUserDTO>> FindAllUsers()
    {
        try
        {
            var users = await _userAccountAdapter.FindAllUsers();

            return users;
        }
        catch (Exception ex) { throw; }
    }

    [HttpPut]
    [Route("update-user")]
    public async Task UpdateUser([FromBody] UpdateUserDTO user)
    {
        try
        {
            await _userAccountAdapter.UpdateUser(user);
        }
        catch (Exception ex) { throw; }
    }
}