namespace PlanarSystemWS.src.Domain.UserManagement;

public interface IUserService
{
    Task Register(User user);
    Task<User> FindById(Guid id);
    Task Update(User origin, User updated);
}