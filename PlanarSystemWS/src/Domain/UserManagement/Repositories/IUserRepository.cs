namespace PlanarSystemWS.src.Domain.UserManagement;

public interface IUserRepository
{
    Task Register(User user);
    Task Update(User origin, User updated);
}