using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Application;

public class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<CustomIdentityUser> _userManager;
    private readonly SignInManager<CustomIdentityUser> _signInManager;
    private readonly IMapper _mapper;

    public AuthenticationService(
        UserManager<CustomIdentityUser> userManager,
        SignInManager<CustomIdentityUser> signInManager,
        IMapper mapper
        )
    {
        _userManager = userManager;
        _signInManager = signInManager;
        _mapper = mapper;
    }

    public async Task<IdentityResult> RegisterUser(User user)
    {
        try
        {
            var userMap = _mapper.Map<CustomIdentityUser>(user);

            var result = await _userManager.CreateAsync(userMap);

            return result;
        }
        catch (Exception ex) { throw; }
    }
}