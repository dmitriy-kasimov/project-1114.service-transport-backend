using AltV.Net.Data;
using transport.domain.core.Freight;

namespace transport.domain.interfaces;

public interface IFrightRepository
{
    public Freight Create(FreightIds freightId, Position position, Rotation rotation);
}