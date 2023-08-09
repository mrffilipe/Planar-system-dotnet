using AutoMapper;
using PlanarSalesWS.src.Domain;

namespace PlanarSalesWS.src.Application;

public class MinimumUserCreatedEventHandler : IEventHandler<MinimumUserCreatedEvent>
{
    private readonly ISalesService _saleService;
    private readonly IMapper _mapper;

    public MinimumUserCreatedEventHandler(ISalesService saleService, IMapper mapper)
    {
        _saleService = saleService;
        _mapper = mapper;
    }

    public async Task HandleEvent(MinimumUserCreatedEvent @event)
    {
        try
        {
            var sellerMap = _mapper.Map<Seller>(@event);

            await _saleService.RegisterSeller(sellerMap);
        }
        catch (Exception ex) { throw; }
    }
}