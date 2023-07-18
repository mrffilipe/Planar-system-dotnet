using PlanarSystemWS.src.Domain.Shared;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;
using PlanarSystemWS.src.Domain.UserManagement;

namespace PlanarSystemWS.src.Domain.SalesManagement;

public class Seller : BaseEntity
{
    public double SalesCommission { get; private set; }
    public Guid UserId { get; private set; }
    public User User { get; private set; }
    public RefBudgetForm? BudgetForm { get; private set; }

    private Seller()
    {
    }

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