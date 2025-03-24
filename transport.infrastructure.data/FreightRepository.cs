using AltV.Net.Data;
using transport.domain.core.Freight;
using transport.domain.interfaces;

namespace transport.infrastructure.data;

public class FreightRepository : IFreightRepository
{
    public Freight Create(FreightModels freightModel, Position position, Rotation rotation)
    {
        return new Freight();
    }
}