using transport.domain.core.subsection.Mechanical.Platform.Fuel.Engine;
using transport.domain.core.subsection.Mechanical.Platform.Fuel.PowerSupply;

namespace transport.domain.core.subsection.Mechanical.Platform.Fuel;

public interface IFuelPlatform : IPlatform
{
    public new IFuelEngine Engine { get; set; }
    public new IFuelPowerSupply PowerSupply { get; set; }
}