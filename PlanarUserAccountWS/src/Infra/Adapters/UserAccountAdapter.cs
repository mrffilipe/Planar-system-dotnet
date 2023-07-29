using AutoMapper;
using PlanarUserAccountWS.src.Application;
using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Infra;

public class UserAccountAdapter : IUserAccountAdapter
{
    private readonly IUserAccountService _userAccountService;
    private readonly IMapper _mapper;

    public UserAccountAdapter(IUserAccountService userAccountService, IMapper mapper)
    {
        _userAccountService = userAccountService;
        _mapper = mapper;
    }

    public async Task RegisterUser(RegisterUserDTO user)
    {
        try
        {
            var userMap = _mapper.Map<User>(user);

            await _userAccountService.RegisterUser(userMap);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<ReplyUserDTO> FindUserById(Guid id)
    {
        try
        {
            var user = await _userAccountService.FindUserById(id);

            return _mapper.Map<ReplyUserDTO>(user);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<ICollection<ReplyUserDTO>> FindAllUsers()
    {
        try
        {
            var users = await _userAccountService.FindAllUsers();

            return _mapper.Map<ICollection<ReplyUserDTO>>(users);
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateUser(UpdateUserDTO user)
    {
        try
        {
            var userMap = _mapper.Map<User>(user);

            await _userAccountService.UpdateUser(userMap);
        }
        catch (Exception ex) { throw; }
    }
}