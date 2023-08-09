namespace PlanarSalesWS.src.Application;

public interface ISalesAdapter
{
    Task<SellerResponseDTO> FindSellerById(Guid id);
    //Task<ReplySellerDTO> UpdateSeller(Seller origin, Seller updated);
    Task<CustomerResponseDTO> FindCustomerById(Guid id);
    //Task<ReplyCustomerDTO> UpdateCustomer(Customer origin, Customer updated);
}