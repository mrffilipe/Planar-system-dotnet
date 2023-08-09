using AutoMapper;
using PlanarUserAccountWS.src.Domain;
using PlanarUserAccountWS.src.Infra;

namespace PlanarUserAccountWS.src.Application;

public class UserAccountService : IUserAccountService
{
    private readonly IUserAccountRepository _userAccountRepository;
    private readonly IMapper _mapper;
    private readonly EventProducer<MinimumUserCreatedEvent> _minimumUserEventProducer;
    private readonly EventProducer<DetailedUserCreatedEvent> _detailedUserEventProducer;

    public UserAccountService(
        IUserAccountRepository userAccountRepository,
        IMapper mapper,
        EventProducer<MinimumUserCreatedEvent> minimumUserEventProducer,
        EventProducer<DetailedUserCreatedEvent> detailedUserEventProducer
        )
    {
        _userAccountRepository = userAccountRepository;
        _mapper = mapper;
        _minimumUserEventProducer = minimumUserEventProducer;
        _detailedUserEventProducer = detailedUserEventProducer;
    }

    public async Task RegisterUser(User user)
    {
        try
        {
            var resultUser = await _userAccountRepository.RegisterUser(user);

            var minimumUserEventMap = _mapper.Map<MinimumUserCreatedEvent>(resultUser);
            _minimumUserEventProducer.PublishEvent(minimumUserEventMap);

            var detailedUserEventMap = _mapper.Map<DetailedUserCreatedEvent>(resultUser);
            _detailedUserEventProducer.PublishEvent(detailedUserEventMap);
        }
        catch (Exception ex) { throw; }
    }

    public async Task<User> FindUserById(Guid id)
    {
        try
        {
            var user = await _userAccountRepository.FindUserById(id);

            return user;
        }
        catch (Exception ex) { throw; }
    }

    public async Task<ICollection<User>> FindAllUsers()
    {
        try
        {
            var users = await _userAccountRepository.FindAllUsers();

            return users;
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateUser(User user)
    {
        try
        {
            await _userAccountRepository.UpdateUser(user);
        }
        catch (Exception ex) { throw; }
    }

    public async Task AddClaimToUser(RefUserClaim claim)
    {
        try
        {
            await _userAccountRepository.AddClaimToUser(claim);
        }
        catch (Exception ex) { throw; }
    }

    public async Task UpdateUserClaim(RefUserClaim claim)
    {
        try
        {
            await _userAccountRepository.UpdateUserClaim(claim);
        }
        catch (Exception ex) { throw; }
    }

    public async Task RemoveUserClaim(RefUserClaim claim)
    {
        try
        {
            await _userAccountRepository.RemoveUserClaim(claim);
        }
        catch (Exception ex) { throw; }
    }
}