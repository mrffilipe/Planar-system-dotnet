using AutoMapper;
using PlanarNotificationWS.src.Application;
using PlanarNotificationWS.src.Domain;

namespace PlanarNotificationWS.src.Infra;

public class UserAdapter : IUserAdapter
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserAdapter(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }

    public async Task Register(UserRegistrationDTO user)
    {
        try
        {
            var userMap = _mapper.Map<User>(user);

            await _userService.Register(userMap);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<ReplyUserDTO> FindById(Guid id)
    {
        try
        {
            var user = await _userService.FindById(id);

            return _mapper.Map<ReplyUserDTO>(user);
        }
        catch (Exception ex) { throw; }
    }

    public async Task Update(UserRegistrationDTO origin, UserRegistrationDTO updated)
    {
        try
        {
            var originMap = _mapper.Map<User>(origin);
            var updatedMap = _mapper.Map<User>(updated);

            await _userService.Update(originMap, updatedMap);
        }
        catch (Exception ex) { throw; }
    }
}
