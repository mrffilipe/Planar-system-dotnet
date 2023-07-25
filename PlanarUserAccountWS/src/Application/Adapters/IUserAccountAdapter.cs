using MongoDB.Bson;

namespace PlanarUserAccountWS.src.Application;

public interface IUserAccountAdapter
{
    Task RegisterUser(UserRegistrationDTO user);
    Task<ReplyUserDTO> FindUserById(string id);
    Task<ICollection<ReplyUserDTO>> FindAllUsers();
    Task UpdateUser(UserRegistrationDTO user);
}