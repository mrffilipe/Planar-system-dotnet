using PlanarSystemWS.src.Domain.shared;

namespace PlanarSystemWS.src.Domain.CustomerManagement;

public class RefDocument : BaseEntity
{
    public Document Document { get; private set; }

    public RefDocument(Document document)
    {
        Document = document;
    }

    public void UpdateDocument(Document document)
    {
        if (document == Document) return;

        Document = document;
    }
}
