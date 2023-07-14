namespace PlanarSystemWS.src.Domain.AddressManagement;

public readonly record struct Address(
        string PostalCode,
        string City,
        string State,
        string Country,
        string District,
        string Street,
        string Complement
    );
