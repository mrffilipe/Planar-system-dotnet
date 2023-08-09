namespace PlanarSalesWS.src.Domain;

public class RefAddress : BaseEntity
{
    public Address Address { get; private set; }
    public Customer? Customer { get; private set; }
    public ICollection<RefBudgetForm>? BudgetForm { get; private set; }

    private RefAddress()
    {
    }

    public RefAddress(Address address)
    {
        Address = address;
    }

    public void UpdateAddress(Address address)
    {
        if (address != Address) Address = address;
    }
}