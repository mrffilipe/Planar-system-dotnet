namespace PlanarSystemWS.src.Domain.CustomerManagement;

public record Document(
        DocumentType Type,
        string Reference
    );