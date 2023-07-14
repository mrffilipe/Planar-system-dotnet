namespace PlanarSystemWS.src.Domain.CustomerManagement;

public readonly record struct Phone(
        string CountryCode,
        string DDD,
        string Number
    );