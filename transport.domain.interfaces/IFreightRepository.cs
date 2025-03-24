using AltV.Net.Data;
using transport.domain.core.Freight;

namespace transport.domain.interfaces;

public interface IFreightRepository
{
    public Freight Create(FreightModels freightModel, Position position, Rotation rotation);
}