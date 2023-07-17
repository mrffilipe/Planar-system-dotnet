namespace PlanarSystemWS.src.Domain.CustomerManagement;

public class Document
{
    public DocumentType Type { get; set; }
    public string Reference { get; set; }
}

//public readonly record struct Document(
//        DocumentType Type,
//        string Reference
//    );