using AltV.Net.Data;
using transport.domain.core.Freight;

namespace transport.services.interfaces;

public interface IFreightService
{
    public void Create(FreightIds freightId, Position position, Rotation rotation);
}