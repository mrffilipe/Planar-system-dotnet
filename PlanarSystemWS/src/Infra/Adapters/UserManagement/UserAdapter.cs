using AutoMapper;
using PlanarSystemWS.src.Application.UserManagement;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Infra.Adapters.UserManagement;

public class UserAdapter : IUserAdapter
{
    private readonly IUserService _userService;
    private readonly IMapper _mapper;

    public UserAdapter(IUserService userService, IMapper mapper)
    {
        _userService = userService;
        _mapper = mapper;
    }
}
