using AutoMapper;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Application;

public class RegisteredUserHandler : IEventHandler<RegisteredUserEvent>
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IMapper _mapper;

    public RegisteredUserHandler(IAuthenticationService authenticationService, IMapper mapper)
    {
        _authenticationService = authenticationService;
        _mapper = mapper;
    }

    public async Task HandleEvent(RegisteredUserEvent @event)
    {
        try
        {
            var userMap = _mapper.Map<User>(@event);

            var result = await _authenticationService.RegisterUser(userMap);

            if(result.Succeeded)
            {
                // validar depois
            }

            throw new Exception();
        }
        catch (Exception ex) { throw; }
    }
}