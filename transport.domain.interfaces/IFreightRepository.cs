using AltV.Net.Data;
using transport.domain.core.Freight;
using transport.domain.core.Freight.Axis;
using transport.domain.core.IGround.IChassis;
using transport.domain.core.IGround.IChassis.WheelChassis;

namespace transport.domain.interfaces;

public interface IFreightRepository
{
    public Freight Create(FreightModels freightModel, Position position, Rotation rotation);
}