namespace PlanarSalesWS.src.Domain;

public class RefBudgetForm : BaseEntity
{
    public BudgetForm BudgetForm { get; private set; }
    public ICollection<ConsumerUnit> ConsumerUnits { get; private set; }
    public Guid SellerId { get; private set; }
    public Seller Seller { get; private set; }
    public Guid CustomerId { get; private set; }
    public Customer Customer { get; private set; }
    public Guid InstallationAddressId { get; private set; }
    public RefAddress InstallationAddress { get; private set; }

    private RefBudgetForm()
    {
    }

    public RefBudgetForm(
        BudgetForm budgetForm,
        ICollection<ConsumerUnit> consumerUnits,
        Seller seller,
        Customer customer,
        RefAddress installationAddress
        )
    {
        BudgetForm = budgetForm;
        ConsumerUnits = consumerUnits;
        Seller = seller;
        Customer = customer;
        InstallationAddress = installationAddress;
    }

    public void AddConsumerUnit(ConsumerUnit consumerUnit)
    {
        if (consumerUnit != null) ConsumerUnits.Add(consumerUnit);
    }

    public void SetSeller(Guid sellerId)
    {
        SellerId = sellerId;
    }
}