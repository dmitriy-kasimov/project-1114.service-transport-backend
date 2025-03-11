using transport.domain.core.IMechanical.Platform.Electric.Engine;
using transport.domain.core.IMechanical.Platform.Electric.PowerSupply;

namespace transport.domain.core.IMechanical.Platform.Electric;

public interface IElectricPlatform : IPlatform
{
    public new IElectricEngine Engine { get; set; }
    public new IElectricPowerSupply PowerSupply { get; set; }
}