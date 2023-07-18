namespace PlanarSystemWS.src.Domain.AddressManagement;

public record Address(
        string PostalCode,
        string City,
        string State,
        string Country,
        string District,
        string Street,
        string Complement
    );