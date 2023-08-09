using AutoMapper;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public class DocumentProfile : Profile
{
    public DocumentProfile()
    {
        CreateMap<RegisterDocumentDTO, RefDocument>()
            .ConstructUsing(s => new RefDocument(
                s.Document
                )
            );
    }
}