using AltV.Net.Data;
using transport.domain.core.Freight;
using transport.domain.core.Freight.Axis;
using transport.domain.core.IGround.IChassis;
using transport.domain.core.IMechanical.IPlatform;

namespace transport.services.interfaces;

public interface IFrightService
{
    public void Create(FreightModels freightModel, Position position, Rotation rotation);
}