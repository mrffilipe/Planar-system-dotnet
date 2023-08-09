namespace PlanarSalesWS.src.Domain;

public record Document(
        DocumentType Type,
        string Reference
    );