using transport.domain.core.subsection.IMechanical.Platform.Electric.Engine;
using transport.domain.core.subsection.IMechanical.Platform.Electric.PowerSupply;

namespace transport.domain.core.subsection.IMechanical.Platform.Electric;

public interface IElectricPlatform : IPlatform
{
    public new IElectricEngine Engine { get; set; }
    public new IElectricPowerSupply PowerSupply { get; set; }
}