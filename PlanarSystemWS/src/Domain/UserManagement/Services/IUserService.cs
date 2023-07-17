namespace PlanarSystemWS.src.Domain.UserManagement;

public interface IUserService
{
    Task Register(User user);
    Task<User> FindById(string id);
    Task Update(User user);
}