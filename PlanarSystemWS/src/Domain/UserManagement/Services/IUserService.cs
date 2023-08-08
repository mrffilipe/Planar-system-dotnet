namespace PlanarSystemWS.src.Domain.UserManagement;

public interface IUserService
{
    Task Register(User user);
    Task Update(User origin, User updated);
}