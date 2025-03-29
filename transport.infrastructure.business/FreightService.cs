using AltV.Net.Data;
using transport.domain.core.Freight;
using transport.infrastructure.data;
using transport.services.interfaces;

namespace transport.infrastructure.business;

public class FreightService : IFreightService
{
    private FrightRepository FrightRepository { get; }
    
    public FreightService()
    {
        FrightRepository = new FrightRepository();
    }

    public void Create(FreightIds freightId, Position position, Rotation rotation)
    {
        var Z = FrightRepository.Create(freightId, position, rotation);
    }
}