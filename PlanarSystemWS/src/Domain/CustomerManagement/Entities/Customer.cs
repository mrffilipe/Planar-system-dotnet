using PlanarSystemWS.src.Domain.AddressManagement;
using PlanarSystemWS.src.Domain.Shared;
using PlanarSystemWS.src.Domain.SolarEnergyManagement;

namespace PlanarSystemWS.src.Domain.CustomerManagement;

public class Customer : BaseEntity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Email { get; private set; }
    public Guid DocumentId { get; private set; }
    public RefDocument Document { get; private set; }
    public Guid PhoneId { get; private set; }
    public RefPhone Phone { get; private set; }
    public Guid AddressId { get; private set; }
    public RefAddress Address { get; private set; }
    public RefBudgetForm? BudgetForm { get; private set; }

    public Customer()
    {
    }

    public Customer(
        string firstName,
        string lastName,
        string email,
        RefDocument document,
        RefPhone phone,
        RefAddress address
        )
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Document = document;
        Phone = phone;
        Address = address;
    }

    public void UpdateDocument(RefDocument document)
    {
        if (document == Document) return;

        Document = document;
    }

    public void UpdatePhone(RefPhone phone)
    {
        if (phone == Phone) return;

        Phone = phone;
    }

    public void UpdateAddress(RefAddress address)
    {
        if (address == Address) return;

        Address = address;
    }
}
