namespace PlanarSalesWS.src.Domain;

public interface ISalesRepository
{
    Task<Seller> RegisterSeller(Seller seller);
    Task<Seller> FindSellerById(Guid id);
    Task<Seller> UpdateSeller(Seller origin, Seller updated);
    Task<Customer> FindCustomerById(Guid id);
    Task<Customer> UpdateCustomer(Customer origin, Customer updated);
}