namespace PlanarChatMessagingWS.src.Domain;

public interface IUserRepository
{
    Task Register(User user);
    Task<User> FindById(Guid id);
    Task Update(User origin, User updated);
}