using AutoMapper;
using PlanarAuthenticationWS.src.Domain;

namespace PlanarAuthenticationWS.src.Application;

public class DetailedUserCreatedEventHandler : IEventHandler<DetailedUserCreatedEvent>
{
    private readonly IAuthenticationService _authenticationService;
    private readonly IMapper _mapper;

    public DetailedUserCreatedEventHandler(IAuthenticationService authenticationService, IMapper mapper)
    {
        _authenticationService = authenticationService;
        _mapper = mapper;
    }

    public async Task HandleEvent(DetailedUserCreatedEvent @event)
    {
        try
        {
            var userMap = _mapper.Map<User>(@event);

            var result = await _authenticationService.RegisterUser(userMap);

            if (!result.Succeeded)
            {
                // validar depois
            }
        }
        catch (Exception ex) { throw; }
    }
}