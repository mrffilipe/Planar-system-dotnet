namespace PlanarSystemWS.src.Domain.CustomerManagement;

public readonly record struct Document(
        DocumentType Type,
        string Reference
    );