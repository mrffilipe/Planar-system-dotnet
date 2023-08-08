using AutoMapper;
using PlanarSystemWS.src.Domain.Shared;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Application.UserManagement;

public class RegisteredUserHandler : IEventHandler<RegisteredUserEvent>
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public RegisteredUserHandler(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    public async Task HandleEvent(RegisteredUserEvent @event)
    {
        try
        {
            var userMap = _mapper.Map<User>(@event);

            await _userService.Register(userMap);
        }
        catch (Exception ex) { throw; }
    }
}