using transport.domain.core.IMechanical.Platform.Fuel.Engine;
using transport.domain.core.IMechanical.Platform.Fuel.PowerSupply;

namespace transport.domain.core.IMechanical.Platform.Fuel;

public interface IFuelPlatform : IPlatform
{
    public new IFuelEngine Engine { get; set; }
    public new IFuelPowerSupply PowerSupply { get; set; }
}