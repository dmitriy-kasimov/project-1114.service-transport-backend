using transport.domain.core.subsection.IMechanical.Platform.Electric;
using transport.domain.core.subsection.IMechanical.Platform.Electric.Engine;
using transport.domain.core.subsection.IMechanical.Platform.Electric.PowerSupply;
using transport.domain.core.subsection.IMechanical.Platform.Fuel;

namespace transport.domain.core.subsection.IMechanical.Platform;

public interface IPlatform
{
    public IEngine Engine { get; set; }
    public IPowerSupply PowerSupply { get; set; }
}