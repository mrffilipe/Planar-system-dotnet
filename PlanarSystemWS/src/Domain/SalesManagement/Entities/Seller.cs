using PlanarSystemWS.src.Domain.shared;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Domain.SalesManagement;

public class Seller : BaseEntity
{
    public User User { get; private set; }
    public double SalesCommission { get; private set; }

    public Seller(User user, double salesCommission)
    {
        User = user;
        SalesCommission = salesCommission;
    }

    public void UpdateSalesCommission(double salesCommission)
    {
        if (salesCommission != SalesCommission) SalesCommission = salesCommission;
    }
}