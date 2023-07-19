using PlanarSystemWS.src.Application.UserManagement;

namespace PlanarSystemWS.src.Application.SalesManagement;

public class SellerRegistrationDTO
{
    public double SalesCommission { get; private set; }
    public UserRegistrationDTO User { get; private set; }
}
