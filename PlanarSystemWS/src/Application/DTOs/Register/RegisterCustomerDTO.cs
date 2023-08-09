namespace PlanarSalesWS.src.Application;

public record RegisterCustomerDTO(
    string FirstName,
    string LastName,
    string Email,
    RegisterDocumentDTO Document,
    RegisterPhoneDTO Phone,
    RegisterAddressDTO Address
    );