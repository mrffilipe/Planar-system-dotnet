namespace PlanarSystemWS.src.Domain.UserManagement;

public interface IUserRepository
{
    Task Register(User user);
    Task<User> FindById(Guid id);
    Task Update(User user);
}
