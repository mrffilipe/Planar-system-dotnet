using AutoMapper;
using MongoDB.Bson;
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

    public Task RegisterUser(UserRegistrationDTO user)
    {
        throw new NotImplementedException();
    }

    public Task<ReplyUserDTO> FindUserById(ObjectId id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<ReplyUserDTO>> FindAllUsers()
    {
        throw new NotImplementedException();
    }

    public Task UpdateUser(UserRegistrationDTO user)
    {
        throw new NotImplementedException();
    }
}