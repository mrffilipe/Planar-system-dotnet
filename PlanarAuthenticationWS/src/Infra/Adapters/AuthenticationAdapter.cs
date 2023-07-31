using AutoMapper;
using PlanarAuthenticationWS.src.Application;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Infra;

public class AuthenticationAdapter : IAuthenticationAdapter
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IMapper _mapper;

    public AuthenticationAdapter(IAuthenticationService authenticationService, IMapper mapper)
    {
        _authenticationService = authenticationService;
        _mapper = mapper;
    }

    public async Task<SignInUserResultDTO> SignIn(SignInUserDTO user)
    {
        try
        {
            var userMap = _mapper.Map<SignInUser>(user);

            var result = await _authenticationService.SignIn(userMap);

            return _mapper.Map<SignInUserResultDTO>(result);
        }
        catch (Exception ex) { throw; }
    }
}