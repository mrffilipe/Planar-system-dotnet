namespace PlanarSystemWS.src.Domain.CustomerManagement;

public record Phone(
        string CountryCode,
        string DDD,
        string Number
    );