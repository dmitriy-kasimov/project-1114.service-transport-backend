using transport.domain.core.Freight.Axis;
using transport.domain.core.IGround.IChassis;
using transport.domain.core.IMechanical.IPlatform;

namespace transport.domain.core.Freight.IFreight;

public interface IFreight
{
    public IAxis Axis { get; }
    public IPlatform Platform { get; }
    public IChassis Chassis { get; }
}