namespace PlanarSystemWS.src.Application.UserManagement;

public interface IUserAdapter
{
    Task Register(UserRegistrationDTO user);
    Task<ReplyUserDTO> FindById(Guid id);
    Task Update(UserRegistrationDTO origin, UserRegistrationDTO updated);
}
