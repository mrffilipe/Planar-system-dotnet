using PlanarUserAccountWS.src.Domain;

namespace PlanarUserAccountWS.src.Application;

public class UpdateUserDTO
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public ICollection<RefUserRole> Roles { get; set; }
    public ICollection<RefUserClaim> Claims { get; set; }
}