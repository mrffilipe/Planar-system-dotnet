namespace PlanarSalesWS.src.Domain;

public class Seller : BaseEntity
{
    public string UserAccountId { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public double SalesCommission { get; private set; }
    public ICollection<RefBudgetForm>? BudgetForm { get; private set; }

    private Seller()
    {
    }

    public Seller(
        string userAccountId,
        string firstName,
        string lastName
        )
    {
        UserAccountId = userAccountId;
        FirstName = firstName;
        LastName = lastName;
        SalesCommission = 5.0;
    }

    public Seller(
        string userAccountId,
        string firstName,
        string lastName,
        double salesCommission
        ) : this(userAccountId, firstName, lastName)
    {
        SalesCommission = salesCommission;
    }

    public void UpdateSalesCommission(double salesCommission)
    {
        if (salesCommission != SalesCommission) SalesCommission = salesCommission;
    }
}