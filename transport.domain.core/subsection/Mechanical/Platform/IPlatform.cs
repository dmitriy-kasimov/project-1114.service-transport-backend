using transport.domain.core.subsection.Mechanical.Platform.Electric;
using transport.domain.core.subsection.Mechanical.Platform.Electric.Engine;
using transport.domain.core.subsection.Mechanical.Platform.Electric.PowerSupply;
using transport.domain.core.subsection.Mechanical.Platform.Fuel;

namespace transport.domain.core.subsection.Mechanical.Platform;

public interface IPlatform
{
    public IEngine Engine { get; set; }
    public IPowerSupply PowerSupply { get; set; }
}