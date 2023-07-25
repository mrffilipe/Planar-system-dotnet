using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Application;

public class UserRegistrationDTO
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public ICollection<UserRole> Roles { get; set; }
    public ICollection<UserClaim> Claims { get; set; }
}