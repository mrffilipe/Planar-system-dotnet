using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Application;

public interface IUserAccountAdapter
{
    Task RegisterUser(RegisterUserDTO user);
    Task<ReplyUserDTO> FindUserById(Guid id);
    Task<ICollection<ReplyUserDTO>> FindAllUsers();
    Task UpdateUser(UpdateUserDTO user);
    Task AddClaimToUser(AddClaimDTO claim);
    Task UpdateUserClaim(UpdateClaimDTO claim);
    Task RemoveUserClaim(RemoveClaimDTO claim);
}