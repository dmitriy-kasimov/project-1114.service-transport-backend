using transport.domain.core.Overland.modules;
using transport.domain.core.Overland.modules.Axis;

namespace transport.domain.core.Overland.dto;

public class OverlandParams<T, TA>(List<Guid> compatibleAxis, Axis<T, TA> axis)
{
    public List<Guid> CompatibleAxis => compatibleAxis;
    
    public Axis<T, TA> Axis => axis;
}