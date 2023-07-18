using PlanarSystemWS.src.Domain.AddressManagement;
using PlanarSystemWS.src.Domain.CustomerManagement;
using PlanarSystemWS.src.Domain.SalesManagement;
using PlanarSystemWS.src.Domain.Shared;

namespace PlanarSystemWS.src.Domain.SolarEnergyManagement;

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

    public RefBudgetForm()
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
}