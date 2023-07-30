using AutoMapper;
using Microsoft.AspNetCore.Identity;
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
}