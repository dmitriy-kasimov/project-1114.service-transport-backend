using AltV.Net.Data;
using transport.domain.core.Freight;
using transport.domain.interfaces;

namespace transport.infrastructure.data;

public class FrightRepository : IFrightRepository
{
    public Freight Create(FreightIds freightId, Position position, Rotation rotation)
    {
        return new Freight(freightId, position, rotation);
    }
}