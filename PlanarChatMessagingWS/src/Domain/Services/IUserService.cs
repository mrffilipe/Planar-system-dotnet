namespace PlanarChatMessagingWS.src.Domain;

public interface IUserService
{
    Task Register(User user);
    Task<User> FindById(Guid id);
    Task Update(User origin, User updated);
}